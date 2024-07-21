using Microsoft.AspNetCore.Mvc;

namespace doktorblog.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
        public IActionResult news1()
        {
            return View();
        }
        public IActionResult news2()
        {
            return View();
        }
        public IActionResult news3()
        {
            return View();
        }
    }
}
