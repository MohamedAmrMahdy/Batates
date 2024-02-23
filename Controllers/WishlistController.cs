using Batates.Models;
using Batates.Repo.IRepo;
using Batates.Repo.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Batates.Controllers
{
    public class WishlistController : Controller
    {
        private readonly IWithlistRepository repo;
        private readonly IWishedItemRepository wishedItemrepo;
        private readonly IProductRepository ProductRepo;

        public WishlistController(IWithlistRepository Repo, IWishedItemRepository wished, IProductRepository productRepo)
        {
            this.repo = Repo;
            this.wishedItemrepo = wished;
            ProductRepo = productRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = repo.GetAll();
            return View(result);
        }
        [HttpGet]
        public IActionResult Overview()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid == null)
                return LocalRedirect("/Identity/Account/Login");
            var UWish = repo.Get(c => c.ApplicationUserID == userid, c => c.WishedProducts);
            var wishProducts = wishedItemrepo.GetAll(cp => cp.Product).Where(cp => UWish.WishedProducts.Contains(cp));
            double total = 0.0;
            if (wishProducts != null && wishProducts.Count() > 0)
            {
                foreach (var wish_product in wishProducts)
                {
                    total += (wish_product.Product.Price);
                }
            }
            ViewBag.Total = total;
            return View(wishProducts);
        }
        [HttpDelete]
        public IActionResult ClearCart()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var uWish = repo.Get(c => c.ApplicationUserID == userid, c => c.WishedProducts);
            List<WishedItem> WishedProductList = uWish.WishedProducts;
            uWish.WishedProducts = new List<WishedItem>();
            repo.Update(uWish);
            WishedProductList.ForEach(p => wishedItemrepo.Delete(p));
            return Json(new { success = true, message = "Cleared the Wished" });
        }

        [HttpPost]
        public IActionResult Add(int id)
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //asp-area="Identity" asp-page="/Account/Manage/Index"
            if (userid == null)
                LocalRedirect("/Identity/Account/Login");
            // Check User Cart First?
            var uWish = repo.Get(c => c.ApplicationUserID == userid, c => c.WishedProducts);
            // user already has cart? Check if the restaurant ID matches
            if (uWish != null)
            {
                var ProductToAdd = ProductRepo.Get(p => p.ID == id);
                if (ProductToAdd != null)
                {
                    if (uWish.WishedProducts.Count == 0)
                    {
                        uWish.WishedProducts = new List<WishedItem>() { new WishedItem() { Product = ProductToAdd } };
                        repo.Update(uWish);
                        return Json(new { Success = true, message = $"Added {ProductToAdd.Name} to Cart!" });
                    }
                    else
                    {
                        var WishProducts = wishedItemrepo.GetAll(cp => cp.Product);
                        var WishProduct=WishProducts.FirstOrDefault(cp => cp.Product.ID==ProductToAdd.ID);
                        if(WishProduct != null)
                        {
                            return Json(new { success = true, message = "Exist" });
                        }
                        uWish.WishedProducts.Add(new WishedItem() { Product = ProductToAdd } );
                        repo.Update(uWish );
                        return Json(new { success = true, message = "Added" });
                    }

                }
            }
            else
            {
                // Generate new Cart for user
                var ProductToAdd = ProductRepo.Get(p => p.ID == id);
                var WishProduct = new WishedItem() { Product = ProductToAdd };
                uWish = new Wishlist() { ApplicationUserID = userid, WishedProducts = new List<WishedItem>() { WishProduct } };
                repo.Create(uWish);
                return Json(new { Success = true, message = $"Added {ProductToAdd.Name} to Cart!" });
            }

            return Json(new { success = false, message = "Invalid" });
        }
        [HttpDelete]
        public IActionResult ClearWish()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var uWish = repo.Get(c => c.ApplicationUserID == userid, c => c.WishedProducts);
            List<WishedItem> wishProductList = uWish.WishedProducts;
            uWish.WishedProducts = new List<WishedItem>();
            repo.Update(uWish);
            wishProductList.ForEach(p => wishedItemrepo.Delete(p));
            return Json(new { success = true, message = "Cleared the Cart" });
        }

    }
}
