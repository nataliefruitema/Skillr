using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Skillr.Models
{
    public class Person
    {
        public int ID { get; set; }

        [StringLength(15, MinimumLength = 2)]
        [Required]
        public string FirstName { get; set; }

        public string Insertion { get; set; }

        [StringLength(20, MinimumLength = 2)]
        [Required]
        public string LastName { get; set; }

        public bool PersonAvailable { get; set; }

        // If person not available
 
        [DataType(DataType.Date)]       
        public DateTime OnProjectUntil { get; set; }

        List<Skills> skills = new List<Skills>();

        List<Projects> projects = new List<Projects>();
    }
    
}
