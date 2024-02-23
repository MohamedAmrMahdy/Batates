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
        // https://startbootstrap.com/template/business-frontpage
        public IActionResult Index()
        {
            return View(CategoryRepo.GetAll());
        }

        // https://startbootstrap.com/template/small-business
        [HttpGet]
        public IActionResult Category(int id)
        {
            ViewBag.category = CategoryRepo.Get(c=>c.ID == id);
            return View(RestaurantRepo.GetAll(r => r.Categories).Where(r => r.Categories.Any(cat => cat.ID == id)));
        }


 



 



 



        // https://www.elmenus.com/cairo/shawerma-el-reem-lnmg 
        // +
        // Product Partial in Product Views
        public IActionResult Restaurant(int id)
        {

            ViewBag.Restaurant = RestaurantRepo.Get(r=>r.ID == id);
            return View(ProductRepo.GetAll().Where(p=>p.RestaurantID == id));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
