using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasMany(prod => prod.Providers)
                .WithMany(prov => prov.Products)
                .UsingEntity(e => e.ToTable("Providing"));  //table d'association
            builder.HasOne(prod => prod.MyCategory)
                .WithMany(c => c.Products)
                .HasForeignKey(prod => prod.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            //builder.HasDiscriminator<int>("IsBiological")
            //    .HasValue<Biological>(1)
            //    .HasValue<Chemical>(2)
            //    .HasValue<Product>(0);
        }
    }
}
