using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Top100Bands.Models;

namespace Top100Bands.Controllers
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
        [HttpGet("List")]
        public IActionResult BandList()
        {
            List<string> bandList = new List<string>();

           

            foreach(Band b in Band.GetBands())
            {
                // bandList.Add($"#{b.BandRanking}: {b.BandName} ({b.BandPoints})"); can do either way or use concatenation
               // int? rank = b.BandRanking - 1 ?? 999; if rank is null insert 999
                
                bandList.Add(string.Format("#{0}: {1} ({2})", b.BandRanking, b.BandName, b.BandPoints)); 
            }
            
            return View(bandList);
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
