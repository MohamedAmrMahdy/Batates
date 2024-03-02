using Batates.Models;
using Batates.Repo.IRepo;
using Batates.Repo.Repo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Batates.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RestaurantController : Controller
    {
        private readonly IRestaurantRepository repo;
        private readonly ICategoryRepository categoryRepository;

        public RestaurantController(IRestaurantRepository Repo,ICategoryRepository categoryRepository)
        {
            this.repo = Repo;
            this.categoryRepository = categoryRepository;
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
            ViewBag.cat =categoryRepository.GetAll().ToList();

            var restaurant = repo.Get(x => x.ID == id,r=>r.Categories);
            return View(restaurant);
        }

        [HttpPost]
        public IActionResult Edit(Restaurant restaurant,List<int> cates)
        {
          
            if(cates?.Count ==0)
            {
                ModelState.AddModelError("Categories", "please select at list single category");
            }

            if (ModelState.IsValid)
            {
                List<Category> categories = new List<Category>();
                foreach (var catid in cates)
                {
                    categories.Add(categoryRepository.Get(cat => cat.ID == catid));
                }
                Restaurant restaurantFromDB = repo.Get(r => r.ID == restaurant.ID, r => r.Categories);
                if (restaurantFromDB.Categories is not null)
                {
                    restaurantFromDB.Categories.Clear();
                }
                restaurantFromDB.Categories = categories;
                int updatedRestaurant = repo.Update(restaurantFromDB);
                TempData["success"] = "restaurant updated successfully";
                return RedirectToAction("index");
            }
            TempData["error"] = "restaurant is Invalid successfully";
            ViewBag.cat = categoryRepository.GetAll().ToList();
            return View(restaurant);
        }

        [HttpGet]
        public ViewResult Create()
        {
            ViewBag.cat = categoryRepository.GetAll().ToList();
            return View();
          
        }

        [HttpPost]
        public IActionResult Create(Restaurant restaurant, List<int> cates)
        {
            if (cates?.Count == 0)
            {
                ModelState.AddModelError("Categories", "please select at list single category");
            }
            if (ModelState.IsValid)
            {
                List<Category> categories = new List<Category>();
                foreach (var catid in cates)
                {
                    categories.Add(categoryRepository.Get(cat => cat.ID == catid));
                }
                if (restaurant.Categories is not null)
                {
                    restaurant.Categories.Clear();
                }
                restaurant.Categories = categories;
                TempData["success"] = "restaurant created successfully";
                repo.Create(restaurant);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.cat = categoryRepository.GetAll().ToList();
            TempData["error"] = "restaurant is Invalid ";
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
