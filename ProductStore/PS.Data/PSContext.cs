using Microsoft.EntityFrameworkCore;
using PS.Data.Configurations;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Data
{
    public class PSContext:DbContext
    {
        public PSContext()
        {
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=KhaledMaammarDB;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CategoryConfiguration().Configure(modelBuilder.Entity<Category>());
            new ProductConfiguration().Configure(modelBuilder.Entity<Product>());
            new ChemicalConfiguration().Configure(modelBuilder.Entity<Chemical>());
            new FactureConfiguration().Configure(modelBuilder.Entity<Facture>());

          //  modelBuilder.Entity<Product>().Property(p => p.Name).HasColumnName("MyName"); if u want to use for one table else just use the loop
           

            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(string) && p.Name.StartsWith("Name")))
            {
                property.SetColumnName("MyName");
            }

            //modelBuilder.HasDiscriminator<int>("IsBiological")
            //    .HasValue<Biological>(1)
            //    .HasValue<Chemical>(2)
            //    .HasValue<Product>(0);

            modelBuilder.Entity<Chemical>().ToTable("Chemicals");
            modelBuilder.Entity<Biological>().ToTable("Biological");
            
        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Facture> Factures { get; set; }

    }
}
