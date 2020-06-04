using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportPortal.Models
{
    public class SupportPortalContext: DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Report> Reports { get; set; }

        public SupportPortalContext(DbContextOptions<SupportPortalContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
    }
}

