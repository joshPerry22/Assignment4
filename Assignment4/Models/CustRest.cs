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
        //[DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]{3}([- /]?[0-9]{4}?$)")]
        public string Phone { get; set; }
    }
}
