using PawelOsajdaZadanieDomowe3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe3.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("ConnectionString")
        {

        }

        // Tabele bazy danych
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<GraphicsCard> GraphicsCards {get; set;}
        public DbSet<Processor> Processors {get; set;}
        public DbSet<Laptop> Laptops {get; set;}
        public DbSet<User> Users {get; set;}
        public DbSet<UserInformations> UserInformations {get; set;}
        public DbSet<Order> Orders {get; set;}
        public DbSet<Suborder> Suborders {get; set;}

    }
}
