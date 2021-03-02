using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransitHub.Controllers
{
    public class Login : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string emailInput, string passwordInput) => RedirectToAction("Index", "Home");
    }
}
