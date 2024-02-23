using Batates.Models;
using Batates.Repo.IRepo;
using Microsoft.AspNetCore.Mvc;

namespace Batates.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrdersRepository repo;

        public OrderController(IOrdersRepository Repo)
        {
            this.repo = Repo;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var result = repo.GetAll();
            return View(result);
        }

        [HttpPost]
        public IActionResult SubmitOrder(List<CartProduct> cartProducts, IFormCollection collection)
        {

            return View();
        }

    }
}
