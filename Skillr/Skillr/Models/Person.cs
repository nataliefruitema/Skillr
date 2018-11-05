using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)] 
        public DateTime OnProjectUntil { get; set; }

    }
}
