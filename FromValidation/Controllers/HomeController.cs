using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FromValidation.Models;

namespace FromValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Trang-Chu/Dang-Ky")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [Route("/Trang-Chu/Dang-Ky")]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterModel register)
        {
            if (!ModelState.IsValid)
            {
                //View lỗi
                return View();
            }
            if(register.pass == "test123123")
            {
                ModelState.AddModelError("", "Mật khẩu không được là: test123123");
                return View();
            }
            return Content("Đăng ký thành công!");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            string mess = string.Empty;
            if (ModelState.IsValid)
            {
                if (student.name == "test")
                {
                    ModelState.AddModelError("","Đây là sản phẩm test lỗi tự do!");
                    ModelState.AddModelError("","Chúng tôi đang test lỗi tự bắt");
                    ModelState.AddModelError("","Hello world! ");
                    return View();
                }
                mess = $"ID: {student.id} - Tên: {student.name} - Mô tả: {student.description}";
                return View();
            }
            else
            {
                return View();
            }
        }

    }
}
