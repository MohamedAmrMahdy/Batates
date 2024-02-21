using Batates.Data;
using Batates.Models;
using Batates.Repo.IRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace Batates.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;
        private readonly IRestaurantRepository restaurantRepo;
        private readonly IOrderProductRepository orderProductRepository;

        public ProductController(IProductRepository Repo, IRestaurantRepository restRepo,IOrderProductRepository orderProductRepository)
        {
            repo = Repo;
            restaurantRepo = restRepo;
            this.orderProductRepository = orderProductRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = repo.GetAll(p => p.Restaurant);
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
            ViewBag.restaurants = new SelectList(restaurantRepo.GetAll(), "ID", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (product is not null)
            {

                if (product.RestaurantID == 0)
                {
                    ModelState.AddModelError("RestaurantID", "please select restaurent");
                }
                if (ModelState.IsValid)
                {
                    repo.Create(product);
                    TempData["success"] = "add successfully";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["error"] = " product is not valid ";
                    return View(product);
                }
            }
            else
            {
                TempData["error"] = " can't not founded";
                return View(product);
            }
        }

        public ActionResult Edit(int id)
        {
            ViewBag.restaurants = new SelectList(restaurantRepo.GetAll(), "ID", "Name");
            return View(repo.Get(p => p.ID == id, p => p.Restaurant));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            if (product is not null)
            {
                if (product.RestaurantID == 0)
                {
                    ModelState.AddModelError("RestaurantID", "please select restaurent");
                }
                if (ModelState.IsValid)
                {
                    var productFromDb = repo.Get(p => p.ID == product.ID);
                    if (productFromDb is not null)
                    {
                        repo.Update(product);
                        TempData["success"] = "update successfully";
                        return RedirectToAction(nameof(Index));
                    }

                }
            }

            ViewBag.restaurants = new SelectList(restaurantRepo.GetAll(), "ID", "Name");
            TempData["error"] = " product is not valid ";
            return View(product);

        }







        //public ActionResult Delete(int id)
        //{
        //    return View(repo.Get(p => p.ID == id));
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(Product product)
        //{
        //    try
        //    {
        //        repo.Delete(product);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        #region API Call
        [HttpGet]
        public ActionResult GettAllProducts()
        {
            var result = repo.GetAll(p => p.Restaurant).Select(p => new { p.ID, p.Name, p.Price, p.RestaurantID, Restaurant = p.Restaurant.Name });
            return Json(new { data = result });
        }
        public ActionResult GettAllProductOrders(int id)
        {
            //to be tested later
            var productOrder = orderProductRepository.Get(op => op.Product.ID == id, op => op.Order, op => op.Order.ApplicationUser);
            var result = new { productOrder.OrderID,productOrder.Order.OrderDate, productOrder.Quantity, productOrder.Order.ApplicationUser.Fullname };
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
                var productFromDb = repo.Get(p => p.ID == id);
                if (productFromDb is not null)
                {
                    repo.Delete(productFromDb);
                    return Json(new { success = true, message = "delete successfully" });

                }
                else
                {
                    return Json(new { success = "false", errorMessage = "cant found product" });

                }
            }

        }


        #endregion
    }
}
