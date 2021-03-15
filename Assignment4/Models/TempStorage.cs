using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public static class TempStorage
    {
        private static List<CustRest> applications = new List<CustRest>();

        public static IEnumerable<CustRest> Applications => applications;

        public static void AddApplication(CustRest application)
        {
            applications.Add(application);
        }
    }
}
