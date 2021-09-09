using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DISample.Api;
using Microsoft.Extensions.Configuration;

namespace DISample.Controllers
{
    public class GetKeyInAppsettingController : Controller
    {
        public IConfiguration _configuration { get; }
        public GetKeyInAppsettingController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // lấy dữ liệu trong file cấu hình appsetting.developer.Json
        public IActionResult Index()
        {
            return Content(new Student().GetString());
        }
    }
}
