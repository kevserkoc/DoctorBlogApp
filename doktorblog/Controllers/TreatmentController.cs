using Microsoft.AspNetCore.Mvc;

namespace doktorblog.Controllers
{
    public class TreatmentController : Controller
    {
        public IActionResult Treatment()
        {
            return View();
        }
    }
}
