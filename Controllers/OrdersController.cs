using Batates.Repo.IRepo;
using Microsoft.AspNetCore.Mvc;

namespace Batates.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersRepository repo;

        public OrdersController(IOrdersRepository Repo)
        {
            this.repo = Repo;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var result = repo.GetAll();
            return View(result);
        }
    }
}
