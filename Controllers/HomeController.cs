using Batates.Models;
using Batates.Repo.IRepo;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Batates.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository ProductRepo;
        private readonly ICategoryRepository CategoryRepo;
        private readonly IRestaurantRepository RestaurantRepo;

        public HomeController(ILogger<HomeController> logger, IProductRepository productRepo, ICategoryRepository categoryRepo, IRestaurantRepository restaurantRepo)
        {
            _logger = logger;
            ProductRepo = productRepo;
            CategoryRepo = categoryRepo;
            RestaurantRepo = restaurantRepo;
        }

        //Home Page - View All Categories + Top Rated Restaurants
        public IActionResult Index()
        {
            return View(CategoryRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Category(int id)
        {
            return View(RestaurantRepo.GetAll(r => r.Categories.Any(cat => cat.ID == id), r => r.Categories));
        }

        public IActionResult Restaurant(int id)
        {

            return View(ProductRepo.GetAll(p => p.RestaurantID == id));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
