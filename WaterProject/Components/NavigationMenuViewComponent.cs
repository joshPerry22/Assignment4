using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterProject.Models;

namespace WaterProject.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {

        private ICharityRepository repository;

        public NavigationMenuViewComponent(ICharityRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedType = RouteData?.Values["category"];

            return View(repository.Projects
                .Select(x => x.Type)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
