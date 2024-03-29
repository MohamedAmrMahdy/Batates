﻿using Batates.Models;
using Batates.Repo.IRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;


namespace Batates.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrdersRepository OrderRepo;
        private readonly IProductRepository ProductRepo;
        private readonly IOrderProductRepository orderProductRepository;
        private readonly ICartProductRepository CartProductRepo;
        private readonly ICartRepository CartRepo;

        public OrderController(IOrdersRepository orderRepo, IProductRepository productRepo, IOrderProductRepository orderProductRepository, ICartRepository cartRepo, ICartProductRepository cpRepo)
        {
            OrderRepo = orderRepo;
            ProductRepo = productRepo;
            this.orderProductRepository = orderProductRepository;
            CartRepo = cartRepo;
            CartProductRepo = cpRepo;

        }

        [HttpGet]
        public IActionResult History()
        {

            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = OrderRepo.GetAll().Where(o => o.ApplicationUserID == userid);
            return View(result);
        }
            
            public IActionResult Index()
            {
            var result = OrderRepo.GetAll(o => o.ApplicationUser);
                return View(result);

            }

        [Authorize(Roles = "Admin")]
        [HttpGet]

        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            else
            {
                var orderFromDatabase = OrderRepo.Get(o => o.ID == id, o => o.ApplicationUser);
                if (orderFromDatabase is not null)
                {

                    ViewBag.orderProducts = orderProductRepository.GetAll(o => o.Product).Where(o => o.OrderID == id).ToList();
                    return View(orderFromDatabase);

                }

                else
                    return NotFound();

            }
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Edit(Order order)
        {
            if (order is null)
                return NotFound();
            else
            {
                if (OrderRepo.Update(order) > 0)
                {
                    TempData["success"] = "order state changes";

                }
                else
                {
                    TempData["error"] = "order state didn't update";
                    ViewBag.orderProducts = orderProductRepository.GetAll(o => o.Product).Where(o => o.OrderID == order.ID).ToList();
                    return View(order);
                }

                return RedirectToAction(nameof(Index));
            }
        }
        #region Call API

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var result = OrderRepo.GetAll(o => o.ApplicationUser).Select(o => new { o.ID, orderDate = o.OrderDate.ToString(), o.State, o.ApplicationUser.UserName, o.TotalPrice }).ToList();
            return Json(result); 
        }

        #endregion

        [HttpPost]
        public IActionResult SubmitOrder(IFormCollection collection)
        {
            var uOrder = new Order();
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            double totalPrice = 0.0;

            uOrder.ApplicationUserID = userid;
            uOrder.OrderDate = DateTime.Now;

            List<OrderProduct> oProducts = new List<OrderProduct>();
            //uOrder.PaymentMethod = collection["paymentType"];
            foreach (var item in collection["ID"])
            {
                int id = int.Parse(item);
                oProducts.Add( new OrderProduct() { Product = ProductRepo.Get(p => p.ID == id) });
            }

            uOrder.OrderProducts = oProducts;

            for(int i=0; i < collection["Quantity"].Count; i++)
            {
                uOrder.OrderProducts[i].Quantity = int.Parse(collection["Quantity"][i]!);
                totalPrice += uOrder.OrderProducts[i].Product.Price * uOrder.OrderProducts[i].Quantity;
            }
            uOrder.TotalPrice = totalPrice;
            if (uOrder.TotalPrice > 0)
            {

                OrderRepo.Create(uOrder);

                // Clear Cart
                var uCart = CartRepo.Get(c => c.ApplicationUserID == userid, c => c.Products);
                List<CartProduct> CardProductList = uCart.Products;
                uCart.Products = new List<CartProduct>();
                CartRepo.Update(uCart);
                CardProductList.ForEach(p => CartProductRepo.Delete(p));

                return RedirectToAction("History");
            }
            else
                return RedirectToAction("Overview", "Cart", new { area = "" });
        }

    }
}
