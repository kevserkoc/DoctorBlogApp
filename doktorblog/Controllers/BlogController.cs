﻿using Microsoft.AspNetCore.Mvc;

namespace doktorblog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog1()
        {
            return View();
        }
        public IActionResult Blog2()
        {
            return View();
        }
        public IActionResult Blog3()
        {
            return View();
        }
    }
}
