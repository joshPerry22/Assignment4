﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WaterProject.Models
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public string Type { get; set; }
        public string Program { get; set; }
        public int Impact { get; set; }
        public string Phase { get; set; }
        public DateTime CompletionDate { get; set; }
        public string Features { get; set; }


    }
}
