using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skillr.Models
{
    public class Skills
    {
        public int ID { get; set; }

        public string Skill { get; set; }

        public string SkillLevel { get; set; }

        public bool Certificate { get; set; }

        public DateTime CertificateValidFrom { get; set; }

        public DateTime CertificateValidUntil { get; set; }

        public int YearsExperience { get; set; }

        List <Person> person = new List<Person>();


    }

}
