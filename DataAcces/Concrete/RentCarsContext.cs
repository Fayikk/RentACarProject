using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete
{
    public class RentCarsContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=FAYIK; DataBase=Deneme5;Trusted_Connection =true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<CarImages> CarImages { get; set; } //Concrete içerisindeki,CarImages dosyamızı veritabanındaki,CarImagess dosyası ile eşleştir anlamına gelmektedir.

    }
}
