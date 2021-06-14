using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    class RentACarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OPGD9LL; Database=RentACar; Trusted_Connection=true");
        }

        public DbSet<Car> Car { get; set; }

        public DbSet<Brand> Brand { get; set; }

        public DbSet<Color> Color { get; set; }
    }
}
