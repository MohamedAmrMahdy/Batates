using Batates.Models;
using Batates.Repo.IRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Batates.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrdersRepository repo;
        private readonly IOrderProductRepository orderProductRepository;

        public OrderController(IOrdersRepository Repo)
        {
            this.repo = Repo;
            this.orderProductRepository = orderProductRepository;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var result = repo.GetAll(o => o.ApplicationUser);
            return View(result);
        }
        [HttpGet]

        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            else
            {
                var orderFromDatabase = repo.Get(o => o.ID == id, o => o.ApplicationUser);
                if (orderFromDatabase is not null)
                {

                    ViewBag.orderProducts = orderProductRepository.GetAll(o => o.Product).Where(o => o.OrderID == id).ToList();
                    return View(orderFromDatabase);

                }

                else
                    return NotFound();

            }
        }
        [HttpPost]
        public IActionResult Edit(Order order)
        {
            if (order is null)
                return NotFound();
            else
            {
                if (repo.Update(order) > 0)
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
            var result = repo.GetAll(o => o.ApplicationUser).Select(o => new { o.ID, orderDate = o.OrderDate.ToString(), o.State, o.ApplicationUser.UserName, o.TotalPrice }).ToList();
            return Json(result);
        }

        #endregion

    }
}
