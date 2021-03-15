using FirstThingsFirst.Models;
using FirstThingsFirst.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstThingsFirst.Controllers
{
    public class HomeController : Controller
    {
        private TaskListContext context { get; set; }

        public HomeController(TaskListContext con)
        {
            context = con;
        }

        public IActionResult Index()
        {
            return View("Index", new QuadrantsViewModel
            {
                Quadrant1 = context.Tasks
                .Where(x => x.Urgent == true && x.Important == true),

                Quadrant2 = context.Tasks
                .Where(x => x.Important == true && x.Urgent == false),

                Quadrant3 = context.Tasks
                .Where(x => x.Important == false && x.Urgent == true),

                Quadrant4 = context.Tasks
                .Where(x => x.Important == false && x.Urgent == false)

            }
            ) ;  
        }
        [HttpGet]
        public IActionResult EnterTask()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnterTask(TaskItem t)
        {
            if (ModelState.IsValid)
            {
                context.Tasks.Add(t);       //DbSet is called Tasks
                context.SaveChanges();
            }
            return View();
        }
    }
}
