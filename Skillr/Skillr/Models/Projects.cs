using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skillr.Models
{
    public class Projects
    {

        public int ID { get; set; }

        public string ProjectNR { get; set; }

        public string ProjectName { get; set; }

        public int ProjectDuration { get; set; }

        public DateTime ProjectStartDate { get; set; }

        public DateTime ProjectEndDate { get; set; }

        public int PersonID { get; set; }

        public Person Person { get; set; }


    }
}
