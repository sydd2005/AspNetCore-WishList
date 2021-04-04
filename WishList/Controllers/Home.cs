using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class Home : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
