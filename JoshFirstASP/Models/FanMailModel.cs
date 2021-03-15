using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JoshFirstASP.Models
{
    public class FanMailModel
    {
        [Required]
        public string from { get; set; }
        [EmailAddress]
        public string email { get; set; }
        public string subject { get; set; }
        [MaxLength(500)]
        public string message { get; set; }

    }
}
