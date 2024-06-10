using Microsoft.AspNetCore.Mvc;

namespace WebClient.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Error() 
        {
            return View();
        }
    }
}
