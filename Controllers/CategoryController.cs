using Batates.Models;
using Batates.Repo.IRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Batates.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {

        private readonly ICategoryRepository repo;

        public CategoryController(ICategoryRepository Repo)
        {
            this.repo = Repo;
        }

        // GET: CategoryController //  this is for App user 
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }
        // GET: CategoryController //  this is for App user 
        public ActionResult GetAll()
        {
            return View(repo.GetAll());
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View(repo.Get(c => c.ID == id));
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                repo.Create(category);
                return RedirectToAction("Details", new { id = category.ID });
            }
            return View(category);
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var category = repo.Get(c => c.ID == id);
            return View(category);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                Category toUpdate = repo.Get(c => c.ID == category.ID);
                toUpdate.Name = category.Name;
                toUpdate.ImageURL = category.ImageURL;
                toUpdate.Description = category.Description;

                int updatedCategory = repo.Update(category);
                return RedirectToAction("GetAll");
            }
            return View(category);
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var category = repo.Get(c => c.ID == id);
            return View(category);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category category)
        {
            int deletedCategory = repo.Delete(category);
            return RedirectToAction("GetAll");
        }
        #region API Call
        [HttpGet]
        public ActionResult GettAllCategories()
        {
            var result = repo.GetAll().Select(c => new { c.ID,c.Name, c.Description,c.ImageURL });
            return Json(new { data = result });
        }
        #endregion

    }
}
