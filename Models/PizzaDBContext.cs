using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PizzaAppplication.Models
{
    public class PizzaDBContext: IdentityDbContext
    {
        public PizzaDBContext(DbContextOptions<PizzaDBContext> options)
            : base(options)
        {

        }
        public DbSet<PizzaModel> Pizza { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<PizzaModel>().HasData(
                new PizzaModel { SNo = 1, ImagePath = "/Double_Cheese_Margherita.jpg", PizzaName = "Double Cheese Margherita", Category = "Veg", Size = "Regular", Price = 180 },
                new PizzaModel { SNo = 2, ImagePath = "/Mexican_Green_Wave.jpg", PizzaName = "Mexican Green Wave", Category = "Veg", Size = "Medium", Price = 390 },
                new PizzaModel { SNo = 3, ImagePath = "/Corn_&_Cheese.jpg", PizzaName = "Cheese N Corn", Category = "Veg", Size = "Large", Price = 490 },
                new PizzaModel { SNo = 4, ImagePath = "/Peppy_Paneer.jpg", PizzaName = "Peppy Paneer", Category = "Veg", Size = "Regular", Price = 210 },
                new PizzaModel { SNo = 5, ImagePath = "/Veggie_Paradise.jpg", PizzaName = "Veggie Paradise", Category = "Veg", Size = "Medium", Price = 390 },
                new PizzaModel { SNo = 6, ImagePath = "/IndianTandooriPaneer.jpg", PizzaName = "Indi Tandoori Paneer", Category = "Veg", Size = "Large", Price = 450 },
                new PizzaModel { SNo = 7, ImagePath = "/Chicken_Golden_Delight.jpg", PizzaName = "Chicken Golden Delight", Category = "Non Veg", Size = "Regular", Price = 230 },
                new PizzaModel { SNo = 8, ImagePath = "/Non-Veg_Supreme.jpg", PizzaName = "Non Veg Supreme", Category = "Non Veg", Size = "Medium", Price = 570 },
                new PizzaModel { SNo = 9, ImagePath = "/Chicken_Fiesta.jpeg", PizzaName = "Chicken Fiesta", Category = "Non Veg", Size = "Large", Price = 690 },
                new PizzaModel { SNo = 10, ImagePath = "/Pepper_Barbeque.jpg", PizzaName = "Pepper Barbecue Chicken", Category = "Non Veg", Size = "Regular", Price = 180 },
                new PizzaModel { SNo = 11, ImagePath = "/Chicken_Sausage.jpg", PizzaName = "Chicken Sausage", Category = "Non Veg", Size = "Medium", Price = 300 },
                new PizzaModel { SNo = 12, ImagePath = "/IndianChickenTikka.jpg", PizzaName = "Indi Chicken Tikka", Category = "Non Veg", Size = "Large", Price = 830 }
                );
        }
    }
}
    