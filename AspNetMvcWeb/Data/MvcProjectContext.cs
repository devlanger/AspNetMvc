using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetMvcWeb.Models
{
    public class MvcProjectContext : DbContext
    {
        public MvcProjectContext (DbContextOptions<MvcProjectContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetMvcWeb.Models.Project> Project { get; set; }
    }
}
