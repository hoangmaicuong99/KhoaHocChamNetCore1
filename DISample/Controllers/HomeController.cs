using DISample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DISampleService;
using DISampleService.DIL;

namespace DISample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;

        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;
        public HomeController(IProductService productService,
            ITransientService transientService1,
            ITransientService transientService2,
            IScopedService scopedService1,
            IScopedService scopedService2,
            ISingletonService singletonService1,
            ISingletonService singletonService2)
        {
            _productService = productService;

            _transientService1 = transientService1;
            _transientService2 = transientService2;

            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;

            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListProduct()
        {
            var product = _productService.GetAll();
            return View(product);
        }
        // Test 3 loại vòng đời
        public IActionResult CreateGuid()
        {
            ViewBag.transient1 = "first :" + _transientService1.GetGuid().ToString();
            ViewBag.transient2 = "second :" + _transientService2.GetGuid().ToString();

            ViewBag.transient3 = "first :" + _scopedService1.GetGuid().ToString();
            ViewBag.transient4 = "second :" + _scopedService2.GetGuid().ToString();

            ViewBag.transient5 = "first :" + _singletonService1.GetGuid().ToString();
            ViewBag.transient6 = "second :" + _singletonService1.GetGuid().ToString();
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
