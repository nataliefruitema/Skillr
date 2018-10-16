using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Skillr.Models;

namespace Skillr.Models
{
    public class SkillrContext : DbContext
    {
        public SkillrContext (DbContextOptions<SkillrContext> options)
            : base(options)
        {
        }

        public DbSet<Skillr.Models.Person> Person { get; set; }

        public DbSet<Skillr.Models.Skills> Skills { get; set; }

        public DbSet<Skillr.Models.Projects> Projects { get; set; }
    }
}
