using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayoutAndSession.Controllers
{
    public class HomeController : Controller
    {
        // có layout và sesion
        public IActionResult Index()
        {
            return View();
        }
        // không có layout
        public IActionResult IndexOne()
        {
            return View();
        }
    }
}
