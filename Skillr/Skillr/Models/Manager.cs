using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Skillr.Models
{
    public class Manager
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }

        public int ProjectsID { get; set; }
        [BindProperty]
        public Projects Project { get; set; }

        public int PersonID { get; set; }
        [BindProperty]
        public Person Person { get; set; }

        public int SkillsID { get; set; }
        [BindProperty]
        public IEnumerable<Skills> Skills { get; set; }

        public IEnumerable<SelectListItem> GetAllSkills()
        {
            return Skills.Select(skill => new SelectListItem
            {
                Value = skill.Skill,
                Text = skill.Skill
            }).ToList();
        }
    }
}
