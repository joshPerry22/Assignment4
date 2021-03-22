using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assignment3.Models.ViewModels;

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {
        //private MovieContext context { get; set; }

        public HomeController(/*MovieContext movie*/)
        {
            //context = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            return View(/*TempStorage.Applications*/); //return what is being stored
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
            if (ModelState.IsValid)
            {
                //context.Movie.Add(Fresponse);
                //context.SaveChanges();
            }

            return View("MovieList", new MovieViewModel
            {
                //movie = context.Movie.Where(x => x.Title != null)
            });
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
