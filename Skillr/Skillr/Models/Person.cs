using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skillr.Models
{
    public class Person
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string Insertion { get; set; }

        public string LastName { get; set; }

        public bool PersonAvailable { get; set; }

        // If person not available
        public DateTime OnProjectUntil { get; set; }

        List<Skills> skills = new List<Skills>();

        List<Projects> projects = new List<Projects>();
    }
    
}
