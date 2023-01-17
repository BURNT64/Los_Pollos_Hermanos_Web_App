using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Los_Pollos_Hermanos_Web_App.Models;

namespace Los_Pollos_Hermanos_Web_App.Data
{
    public class ResturantContext : IdentityDbContext<ApplicationUser>
    {
        public ResturantContext(DbContextOptions<ResturantContext> options) : base(options)
        {
        }
        public DbSet<Food> Food { get; set; }
        public DbSet<MenuInfromation> MenuInfromation { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers{ get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Food>().ToTable("Food");
            modelBuilder.Entity<MenuInfromation>().ToTable("Menuinformation");
            modelBuilder.Entity<MenuItem>().ToTable("MenuItem");
            modelBuilder.Entity<ApplicationUser>().ToTable("ApplicationUsers");
        }
    }
}