using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ENAP.Models;

namespace ENAP.Controllers
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
        public IActionResult Antecedentes()
        {
            return View();
        }
        public IActionResult Especie()
        {
            return View();
        }
        public IActionResult Sitios()
        {
            return View();
        }
        public IActionResult Repoblamiento()
        {
            return View();
        }
        public IActionResult Arrecifes()
        {
            return View();
        }
        public IActionResult Siembra()
        {
            return View();
        }

        public IActionResult Fisica()
        {
            return View();
        }
        public IActionResult Quimica()
        {
            return View();
        }
        public IActionResult Biologica()
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
