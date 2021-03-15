using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstThingsFirst.Models
{
    public class TaskItem
    {
        [Key]
        [Required]
        public int TaskId { get; set; }
        [Required]
        public string TaskDescription { get; set; }
        [Required]
        public bool Urgent { get; set; }
        [Required]
        public bool Important { get; set; }

        public string GetQuadrant ()
        {
            string quadrantName = "";

            if (Urgent == true && Important == true)
            {
                quadrantName = "Quadrant 1";
            }

            else if (!Urgent && Important) //not urgent but important
            {
                quadrantName = "Quadrant 2";
            }

            else if (Urgent && !Important)
            {
                quadrantName = "Quadrant 3";
            }

            else if (!Urgent && !Important)
            {
                quadrantName = "Quadrant 4";
            }
                
            return quadrantName;
        }
    }
}
