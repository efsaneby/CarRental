using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EntityFramework
{
    public class CarRentalContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=desktop-sqjm358\sqlexpress;Database=CarRental;Trusted_Connection=True;Encrypt=false");
        }

            public DbSet<Brand> Brands { get; set; }
            public DbSet<Car> Cars { get; set; }
            public DbSet<Color> Colors { get; set; }
       
    }  
}
