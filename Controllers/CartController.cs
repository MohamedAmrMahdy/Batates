using Batates.Models;
using Batates.Repo.IRepo;
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
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            // Check User Cart First?
            var uCart = CartRepo.Get(c => c.ApplicationUserID == userid, c => c.Products);
            // user already has cart? Check if the restaurant ID matches
            if (uCart != null)
            {
                var ProductToAdd = ProductRepo.Get(p => p.ID == id);
                if (ProductToAdd != null)
                {
                    if (ProductToAdd.RestaurantID == restid)
                    {
                        if (uCart.Products == null)
                        {
                            uCart.Products = new List<CartProduct>() { new CartProduct() { Product = ProductToAdd, Quantity = 1 } };
                            CartRepo.Update(uCart);
                            return Json(new { Success = true, message = "Added successfully to Cart!" });
                        }
                        else
                        {
                            // Check if item already is in Cart
                            var cartProducts = CartProductRepo.GetAll(cp => cp.Product).Where(cp => uCart.Products.Contains(cp));
                            var cartProduct = cartProducts.FirstOrDefault(cp => cp.Product.ID == ProductToAdd.ID);
                            if (cartProduct != null)
                            {
                                cartProduct.Quantity += 1;
                                CartProductRepo.Update(cartProduct);
                                return Json(new { Success = true, message = "Incremented Count in Cart!" });
                            }
                            else
                            {
                                uCart.Products.Add( new CartProduct() { Product = ProductToAdd, Quantity = 1 });
                                CartRepo.Update(uCart);
                                return Json(new { Success = true, message = "Added successfully to Cart!" });

                            }
                        }
                    }
                    else
                    {
                        // Not Same Restaurant ID
                        // Clear Cart then Create new one but check with user first.
                        return Json(new { Success = false, message = "Already got a Cart from another Restaurant" });
                    }
                }
            }
            else
            {
                var ProductToAdd = ProductRepo.Get(p => p.ID == id);
                var CartProduct = new CartProduct() { Product = ProductToAdd, Quantity = 1 };
                uCart = new Cart() { ApplicationUserID = userid, Products = new List<CartProduct>() { CartProduct } };
                CartRepo.Create(uCart);
                return Json(new { Success = true, message = "Added successfully to Cart!" });
            }

            return Json(new { success = false });
        }

    }
}
