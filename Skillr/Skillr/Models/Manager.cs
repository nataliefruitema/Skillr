using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skillr.Models
{
    public class Manager
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }

        public int ProjectsID { get; set; }
        public Projects Project { get; set; }

        public int PersonID { get; set; }
        public Person Person { get; set; }

        public int SkillsID { get; set; }
        public IEnumerable<Skills> Skills { get; set; }
    }
}
