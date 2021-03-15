using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentOne.Models
{
    public class GradeCalcModel
    {  //setting a range with getters and setters
        [Range(0.00, 100.00)]
        public int hw { get; set; }
        [Range(0.00, 100.00)]
        public int groupProject { get; set; }
        [Range(0.00, 100.00)]
        public int quiz { get; set; }
        [Range(0.00, 100.00)]
        public int exam { get; set; }
        [Range(0.00, 100.00)]
        public int intex { get; set; }
       
    }
}
