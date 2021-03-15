using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Controllers
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

        public IActionResult MovieList()
        {
            return View(TempStorage.Applications); //return what is being stored
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }
        

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(FormResponse Fresponse)
        {
           // if (ModelState.IsValid)
            //{
            //    Response.Redirect("Home/MovieForm");
           // }
            TempStorage.AddApplication(Fresponse); //add info to storage than pop up Confirmation page
            return View("Confirmation", Fresponse);
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
