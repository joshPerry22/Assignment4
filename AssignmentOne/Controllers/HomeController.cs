using AssignmentOne.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentOne.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //displaying page views

        [HttpGet("GradeCalc")]
        public IActionResult GradeCalc()
        {
            return View();
        }

        [HttpPost("GradeCalc")]
        public IActionResult GradeCalc(GradeCalcModel model)
        {
            return View();
        }
    }
}
