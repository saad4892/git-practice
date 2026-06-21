using Microsoft.AspNetCore.Mvc;

namespace Git_Practice.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
