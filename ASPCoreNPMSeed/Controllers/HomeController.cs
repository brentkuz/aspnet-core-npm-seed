using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCoreNPMSeed.Models;
using ASPCoreNPMSeed.Models.Home;

namespace ASPCoreNPMSeed.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var vm = new IndexViewModel
            {
                ConfigValue1 = "Yep",
                ConfigValue2 = 123
            };
            return View(vm);
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
