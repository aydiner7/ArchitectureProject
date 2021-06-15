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

        public DbSet<Car> Cars { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<CaseType> CaseTypes { get; set; }
    }
}
