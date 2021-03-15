using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
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
             List<string> restList = new List<string>();

            
            //creating a format and setting null answers
            foreach(Rest r in Rest.GetRest())
            {
                string? dish = r.Dish ?? "It's all tasty";
                string? link = r.Link ?? "Coming soon";
                restList.Add(string.Format("#{0}  {1}  {2},  {3}  {4} VIN: {5}  ", r.Rank, r.Name, dish, r.Address, r.Phone, link));
                //restList.Add(r.Rank + " " + r.Name + "<br>" + dish + "<br>" + r.Address + "<br>" + r.Phone + "<br>" + link + "<br>" + "<br>");
            }
            return View(restList); 
        }
        [HttpGet]
        public IActionResult CustomerPicks()
        {
            return View();
        }
        //after form is submitted
        [HttpPost]
        public IActionResult CustomerPicks(CustRest restResponse)
        {
            
            TempStorage.AddApplication(restResponse);
            return View("Confirmation", restResponse);
        }
        //grabbing from tempstorage
        public IActionResult CustList()
        {
            
            return View(TempStorage.Applications);
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
