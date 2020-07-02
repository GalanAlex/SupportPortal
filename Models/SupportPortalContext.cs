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
        public DbSet<Role> Roles { get; set; }

        public SupportPortalContext(DbContextOptions<SupportPortalContext> options)
            : base(options)
        {
            
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRoleName = "admin";
            string userRoleName = "user";

            // добавляем тестовые роли
            Role adminRole = new Role { Id = 1, Name = adminRoleName };
            Role userRole = new Role { Id = 2, Name = userRoleName };
            // добавляем тестовых пользователей
            Person adminUser1 = new Person { Id = 5, Email = "admin@mail.com", Password = "123456", RoleId = adminRole.Id };
            Person adminUser2 = new Person { Id = 6, Email = "tom@mail.com", Password = "123456", RoleId = adminRole.Id };
            Person simpleUser1 = new Person { Id = 7, Email = "bob@mail.com", Password = "123456", RoleId = userRole.Id };
            Person simpleUser2 = new Person { Id = 8, Email = "sam@mail.com", Password = "123456", RoleId = userRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<Person>().HasData(new Person[] { adminUser1, adminUser2, simpleUser1, simpleUser2 });
            base.OnModelCreating(modelBuilder);
        }*/

    }
}
 
