using Batates.Models;
using Batates.Repo.IRepo;
using Batates.Repo.Repo;
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
        public IActionResult Edit(int id)
        {
            var restaurant = repo.Get(x => x.ID == id);
            return View(restaurant);
        }

        [HttpPost]
        public IActionResult Edit(Restaurant restaurant)
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


        public ActionResult Delete(int id)
        {
            var restaurant = repo.Get(c => c.ID == id);
            return View(restaurant);
        }
        //hello
        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Restaurant restaurant)
        {
            int deletedCategory = repo.Delete(restaurant);
            return RedirectToAction("ViewAll");
        }

        #region API Call
        [HttpGet]
        public ActionResult GettAllRestaurants()
        {
            var result = repo.GetAll().Select(p => new { p.ID, p.Name, State = p.State.ToString(), p.ContactNo });
            return Json(new { data = result });
        }
        [HttpDelete]
        public ActionResult Delete(int? id)
        {
            if (id is null)
            {
                return Json(new { success = "false", message = "id can't not be null" });
            }
            else
            {
                var restaurantFromDb = repo.Get(p => p.ID == id);
                if (restaurantFromDb is not null)
                {
                    repo.Delete(restaurantFromDb);
                    return Json(new { success = true, message = "delete successfully" });

                }
                else
                {
                    return Json(new { success = "false", errorMessage = "cant find restaurant" });

                }
            }

        }

        #endregion
    }
}
