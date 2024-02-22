using Batates.Models;
using Batates.Repo.IRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Batates.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartRepository CartRepo;
        private readonly IRestaurantRepository ResRepo;
        private readonly IProductRepository ProductRepo;
        private readonly ICartProductRepository CartProductRepo;

        public CartController(ICartRepository cartRepo, IRestaurantRepository resRepo, IProductRepository productRepo, ICartProductRepository cpRepo)
        {
            CartRepo = cartRepo;
            ResRepo = resRepo;
            ProductRepo = productRepo;
            CartProductRepo = cpRepo;
        }
        [HttpPost]
        public IActionResult Add(int id, int restid)
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //asp-area="Identity" asp-page="/Account/Manage/Index"
            if (userid == null)
                LocalRedirect("/Identity/Account/Login"); ;
            // Check User Cart First?
            var uCart = CartRepo.Get(c => c.ApplicationUserID == userid, c => c.Products);
            // user already has cart? Check if the restaurant ID matches
            if (uCart != null)
            {
                var ProductToAdd = ProductRepo.Get(p => p.ID == id);
                if (ProductToAdd != null)
                {
                    if (uCart.Products.Count == 0)
                    {
                        uCart.Products = new List<CartProduct>() { new CartProduct() { Product = ProductToAdd, Quantity = 1 } };
                        CartRepo.Update(uCart);
                        return Json(new { Success = true, message = $"Added {ProductToAdd.Name} to Cart!" });
                    }
                    else
                    {
                        var cartProducts = CartProductRepo.GetAll(cp => cp.Product).Where(cp => uCart.Products.Contains(cp));
                        if (ProductToAdd.RestaurantID == cartProducts.First().Product.RestaurantID)
                        {
                            var cartProduct = cartProducts.FirstOrDefault(cp => cp.Product.ID == ProductToAdd.ID);
                            // Check if item already is in Cart
                            if (cartProduct != null)
                            {
                                // increment CartProduct count
                                cartProduct.Quantity += 1;
                                CartProductRepo.Update(cartProduct);
                                return Json(new { Success = true, message = $"Incremented {ProductToAdd.Name} in Cart!" });
                            }
                            else
                            {
                                // Add the item to Cart with Quantity of 1
                                uCart.Products.Add(new CartProduct() { Product = ProductToAdd, Quantity = 1 });
                                CartRepo.Update(uCart);
                                return Json(new { Success = true, message = $"Added {ProductToAdd.Name} to Cart!" });
                            }
                        }
                        else
                        {
                            // Redirect user to ClearCart action
                            return Json(new { Success = false, message = "Already got a Cart from another Restaurant" });
                        }
                    }


                }
            }
            else
            {
                // Generate new Cart for user
                var ProductToAdd = ProductRepo.Get(p => p.ID == id);
                var CartProduct = new CartProduct() { Product = ProductToAdd, Quantity = 1 };
                uCart = new Cart() { ApplicationUserID = userid, Products = new List<CartProduct>() { CartProduct } };
                CartRepo.Create(uCart);
                return Json(new { Success = true, message = $"Added {ProductToAdd.Name} to Cart!" });
            }

            return Json(new { success = false, message = "Invalid" });
        }

        // Do not touch this
        // This is the only way to
        // A) Clear Products list in Cart of the user.
        // B) Clear Each Product from CartProduct Table (their CartID becomes NULL)
        [HttpDelete]
        public IActionResult ClearCart()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var uCart = CartRepo.Get(c => c.ApplicationUserID == userid, c => c.Products);
            List<CartProduct> CardProductList = uCart.Products;
            uCart.Products = new List<CartProduct>();
            CartRepo.Update(uCart);
            CardProductList.ForEach(p => CartProductRepo.Delete(p));
            return Json(new { success = true, message = "Cleared the Cart" });
        }

        [HttpGet]
        public IActionResult Overview()
        {
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid == null)
                return LocalRedirect("/Identity/Account/Login");
            var uCart = CartRepo.Get(c => c.ApplicationUserID == userid, c => c.Products);
            var cartProducts = CartProductRepo.GetAll(cp => cp.Product).Where(cp => uCart.Products.Contains(cp));
            double total = 0.0;
            if(cartProducts != null && cartProducts.Count() > 0)
            {
                foreach(var cartProduct in cartProducts)
                {
                    total += (cartProduct.Product.Price * cartProduct.Quantity);
                }
            }
            ViewBag.Total = total;
            return View(cartProducts);
        }

    }
}
