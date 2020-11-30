using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DetectiveAgency.Models;

namespace DetectiveAgency.Controllers
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
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CalcPay()
        {
            ViewBag.Salary = 0;
            return View();
        }
        [HttpPost]
        public IActionResult CalcPay(Employee model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Salary = model.CalcSalary();
            }
            else
            {
                ViewBag.Salary = 0;
            }
            return View(model);
        }
        public IActionResult mainOfficeEmployees()
        {
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
