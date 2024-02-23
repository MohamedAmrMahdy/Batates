using Batates.Models;
using Batates.Models.Enums;
using Batates.Repo.IRepo;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Batates.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrdersRepository OrderRepo;
        private readonly IProductRepository ProductRepo;

        public OrderController(IOrdersRepository orderRepo, IProductRepository productRepo)
        {
            OrderRepo = orderRepo;
            ProductRepo = productRepo;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = OrderRepo.GetAll().Where(o => o.ApplicationUserID == userid);
            return View(result);
        }

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
            OrderRepo.Create(uOrder);

            return RedirectToAction("Index");
        }

    }
}
