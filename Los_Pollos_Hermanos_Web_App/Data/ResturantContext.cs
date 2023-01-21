using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Los_Pollos_Hermanos_Web_App.Models;

namespace Los_Pollos_Hermanos_Web_App.Data
{
    public class ResturantContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IConfiguration _config;

        public ResturantContext(DbContextOptions<ResturantContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        public DbSet<Food> Food { get; set; }
        public DbSet<MenuInfromation> MenuInfromation { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Food>().ToTable("Food");
            modelBuilder.Entity<MenuInfromation>().ToTable("Menuinformation");
            modelBuilder.Entity<MenuItem>().ToTable("MenuItem");
            modelBuilder.Entity<ApplicationUser>().ToTable("ApplicationUsers");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config.GetConnectionString("ResturantContext"));
        }
    }
}