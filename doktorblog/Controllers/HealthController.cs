using Microsoft.AspNetCore.Mvc;

namespace doktorblog.Controllers
{
    public class HealthController : Controller
    {
        public IActionResult Health()
        {
            return View();
        }
    }
}
