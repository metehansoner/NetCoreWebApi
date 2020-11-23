using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UdemyNLayerProject.Core;
using UdemyNLayerProject.Core.Models;
using UdemyNLayerProject.Data.Configuration;
using UdemyNLayerProject.Data.Seeds;

namespace UdemyNLayerProject.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
           
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TOBLO OLUŞMADAN ÖNCE ÇALIŞAN METOD//integer primary key vs ama temiz olması için conf 
            //configuration dosyasında yaptık
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2 }));
        }
    }
}
