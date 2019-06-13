namespace Bogota_Robotics_Company.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Entities;

    public class DataContext:IdentityDbContext<User>
    {
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Post> Posts{ get; set; }
        public DbSet<Project> Projects { get; set; }

        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
    }
}
