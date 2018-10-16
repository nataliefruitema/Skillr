using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Skillr.Models
{
    public class Projects
    {

        public int ID { get; set; }

        [Display(Name = "ProjectNumber")]
        [RegularExpression(@"[0-9]*$", ErrorMessage = "A number must be entered here")]
        [Required]
        public string ProjectNR { get; set; }

        [StringLength(15, MinimumLength = 2)]
        [Required]
        public string ProjectName { get; set; }

        [Display(Name = "Duration of the project in weeks")]
        public int ProjectDuration { get; set; }

        [DataType(DataType.Date)]
        public DateTime ProjectStartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ProjectEndDate { get; set; }

        public int PersonID { get; set; }

        public Person Person { get; set; }


    }
}
