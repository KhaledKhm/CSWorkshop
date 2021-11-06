using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configurations
{
    public class FactureConfiguration : IEntityTypeConfiguration<Facture>
    {
        public void Configure(EntityTypeBuilder<Facture> builder)
        {
            builder.HasKey(f => new {
                f.ClientFK,
                f.ProductFK,
                f.DateAchat
            });
            builder.HasOne(f => f.Client)
                .WithMany(c => c.Factures)
                .HasForeignKey(f => f.ClientFK);
            builder.HasOne(f => f.Product)
                .WithMany(p => p.Factures)
                .HasForeignKey(f => f.ProductFK);
        }
    }
}
