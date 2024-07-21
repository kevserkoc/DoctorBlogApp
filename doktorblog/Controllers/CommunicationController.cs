using Microsoft.AspNetCore.Mvc;

namespace doktorblog.Controllers
{
    public class CommunicationController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
        
    }
}
