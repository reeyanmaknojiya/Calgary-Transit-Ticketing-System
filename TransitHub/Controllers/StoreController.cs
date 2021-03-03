using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransitHub.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Tickets()
        {
            return View();
        }

        public IActionResult Passes()
        {
            return View();
        }
    }
}
