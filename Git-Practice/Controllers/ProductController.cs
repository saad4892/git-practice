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



        [HttpGet]
        public IActionResult add()
        {
            /*  int x = 10;*/
            int y = 10;
            return View();
        }
    }
}
