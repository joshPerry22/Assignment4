using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public static class TempStorage
    {
        private static List<FormResponse> applications = new List<FormResponse>();

        public static IEnumerable<FormResponse> Applications => applications;

        public static void AddApplication(FormResponse application)
        {
            applications.Add(application);
        }
    }
}
