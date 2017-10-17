using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fonour.IMS.MVC.Models;
using Fonour.IMS.Application.System.MenuApp;

namespace Fonour.IMS.MVC.Controllers
{
    public class HomeController : IMSControllerBase
    {
        private IMenuAppService _service;

        public HomeController(IMenuAppService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            Logger.Error("测试。");
            _service.GetAll();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
