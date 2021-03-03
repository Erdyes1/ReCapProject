using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class ReCapProjectContext:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB, database=reCapProject, Trusted_Connection=true");
        }

        public DbSet<Brand> brands  { get; set; }
        public DbSet<Car>   cars    { get; set; }
        public DbSet<Color> colors  { get; set; }

    }
}
