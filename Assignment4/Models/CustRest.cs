using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class CustRest
    {
        public string CustName { get; set; }
        public string Name { get; set; }

        public string? Dish { get; set; } 
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}
