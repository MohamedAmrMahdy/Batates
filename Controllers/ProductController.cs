using Batates.Data;
using Batates.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Batates.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Route("/Product/{id?}")]
        public async Task<IActionResult> Index(int? id)
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
                Product dbProduct = await _context.Products.FirstOrDefaultAsync(p => p.ID == id);
                if (dbProduct != null)
                {
                    dbProduct.Description = dbProduct.Description;
                    product = dbProduct;
                }
            }
            return View(product);
        }
    }
}
