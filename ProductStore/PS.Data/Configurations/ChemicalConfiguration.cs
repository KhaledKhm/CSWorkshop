using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configurations
{
    public class ChemicalConfiguration : IEntityTypeConfiguration<Chemical>
    {
        public void Configure(EntityTypeBuilder<Chemical> builder)
        {
            builder.OwnsOne(c => c.MyAddress, //equivalent of [owned]
                adr => { adr.Property(x => x.City).IsRequired().HasColumnName("MyCity");
                         adr.Property(x => x.StreetAddress).HasMaxLength(50).HasColumnName("MyAddress");
                });
        }
    }
}
