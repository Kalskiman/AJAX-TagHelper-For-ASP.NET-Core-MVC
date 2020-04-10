using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NF.Samples.UsingAjaxTagHelpers.Models;

namespace NF.Samples.UsingAjaxTagHelpers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult modaltest()
        {
            return PartialView();
        }
        public IActionResult test()
        {
            Thread.Sleep(1000);
            return PartialView();
        }

        public IActionResult anothertest()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SaveData(SampleDataModel model)
        {
            return PartialView(model);
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
