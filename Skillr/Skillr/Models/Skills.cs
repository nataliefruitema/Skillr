using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Skillr.Models
{
    public class Skills
    {
        public int ID { get; set; }


        [StringLength(15, MinimumLength = 2)]
        [Required]
        public string Skill { get; set; }


        [Display(Name = "SkillLevel on a scale of 1 - 10")]
        [RegularExpression(@"[0-9]*$", ErrorMessage = "A number from 1 - 10 must be entered here")]
        public string SkillLevel { get; set; }

        public bool Certificate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CertificateValidFrom { get; set; }

        [DataType(DataType.Date)]
        public DateTime CertificateValidUntil { get; set; }

        [Display(Name = "Duration of the project in years")]
        public int YearsExperience { get; set; }

        List <Person> person = new List<Person>();


    }

}
