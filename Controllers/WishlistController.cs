using Microsoft.AspNetCore.Mvc;

namespace Batates.Controllers
{
    public class WishlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
