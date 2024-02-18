using Batates.Models;
using Batates.Repo.IRepo;
using Microsoft.AspNetCore.Mvc;

namespace Batates.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantRepository repo;

        public RestaurantController(IRestaurantRepository Repo)
        {
            this.repo = Repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = repo.GetAll();
            return View(result);
        }
        [HttpGet]
        public IActionResult ViewAll()
        {
            var result = repo.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var restaurant = repo.Get(x => x.ID == id);
            return View(restaurant);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var restaurant = repo.Get(x => x.ID == id);
            return View(restaurant);
        }

        [HttpPost]
        public IActionResult Update(Restaurant restaurant)
        {

            if (ModelState.IsValid)
            {

                Restaurant toUpdate = repo.Get(x => x.ID == restaurant.ID);
                toUpdate.Name = restaurant.Name;
                toUpdate.Description = restaurant.Description;
                toUpdate.ContactNo = restaurant.ContactNo;
                toUpdate.State = restaurant.State;
                toUpdate.ImageURL = restaurant.ImageURL;

                int updatedRestaurant = repo.Update(restaurant);
                return RedirectToAction("index");
            }
            return View(restaurant);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                repo.Create(restaurant);
                return RedirectToAction("Details", new { id = restaurant.ID });
            }

            return View(restaurant);
        }
    }
}
