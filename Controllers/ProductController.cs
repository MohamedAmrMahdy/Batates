using Batates.Data;
using Batates.Models;
using Batates.Repo.IRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace Batates.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;

        public ProductController(IProductRepository Repo)
        {
            this.repo = Repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = repo.GetAll(p=>p.Restaurant);
            return View(result);
        }

        public IActionResult Details(int? id)
        {
            Product product = new Product()
            {
                ID = -1,
                Name = "Iphone Pro Max",
                Price = 3000.13,
                Description = "Lorem ipsum dolor sit amet, consectetur adipis cingelit. Etiam lacinia elit et placerat finibus. Praesent justo metus, pharetra vel nibh sit amet, tincidunt posuere nulla. Vivamus odio antement, feugiat eget nisi sit amet, scelerisque dignissim velit antement.",
                ImageURL = "https://www.cnet.com/a/img/resize/62bab0c1af4f9fff7da9fc9465ea0abd057a9e1a/hub/2023/09/18/5610b8e1-754e-48d7-90c1-ca24f70b0218/iphone15-pro-83.jpg?auto=webp&fit=crop&height=675&width=1200"
            };
            if (id != null)
            {
                Product dbProduct = repo.Get(p => p.ID == id, p => p.Restaurant);
                if (dbProduct != null)
                {
                    dbProduct.Description = dbProduct.Description;
                    product = dbProduct;
                }
            }
            return View(product);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                repo.Create(product);
                return RedirectToAction("Details", new { id = product.ID });
            }

            return View(product);
        }

        public ActionResult Edit(int id)
        {
            return View(repo.Get(p => p.ID == id, p => p.Restaurant));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                repo.Update(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View(repo.Get(p => p.ID == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Product product)
        {
            try
            {
                repo.Delete(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
