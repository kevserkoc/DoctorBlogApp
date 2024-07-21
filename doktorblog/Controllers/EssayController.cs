using Microsoft.AspNetCore.Mvc;

namespace doktorblog.Controllers
{
    public class EssayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Essay1()
        {
            return View();
        }
        public IActionResult Essay2()
        {
            return View();
        }
        public IActionResult Essay3()
        {
            return View();
        }
    }
}

