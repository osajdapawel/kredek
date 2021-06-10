using Microsoft.EntityFrameworkCore;
using PawelOsajdaZadanieDomowe6.Models.Entities;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe6.Models
{
    /// <summary>
    /// Klasa kontekstu bazy danych
    /// </summary>
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
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
