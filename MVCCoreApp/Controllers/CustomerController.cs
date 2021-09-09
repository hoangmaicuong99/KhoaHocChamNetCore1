using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class CustomerController : Controller
    {
        // Đang làm tới đây. Cơ chế routing
        public IActionResult Index(string id)
        {
            IndexModel indexModel = new IndexModel();
            indexModel.description = id;
            return View(indexModel);
        }
        // Tạo view đầu tiên...
        public IActionResult IndexOne()
        {
            return View();
        }
        public IActionResult IndexTwo(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
