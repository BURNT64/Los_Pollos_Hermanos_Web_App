using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Los_Pollos_Hermanos_Web_App.Models;

namespace Los_Pollos_Hermanos_Web_App.Data
{
    public class ResturantContext : DbContext
    {
        public ResturantContext(DbContextOptions<ResturantContext> options) : base(options)
        {
        }

        public DbSet<Food> Food { get; set; }
        public DbSet<MenuInfromation> MenuInfromation { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().ToTable("Food");
            modelBuilder.Entity<MenuInfromation>().ToTable("Menuinformation");
            modelBuilder.Entity<MenuItem>().ToTable("MenuItem");
        }

    }
}
