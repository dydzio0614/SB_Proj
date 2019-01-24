using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SB_Proj.Models
{
    public class SBProjContext : DbContext
    {
        public SBProjContext (DbContextOptions<SBProjContext> options)
            : base(options)
        {
        }

        public DbSet<SB_Proj.Models.Book> Book { get; set; }
    }
}
