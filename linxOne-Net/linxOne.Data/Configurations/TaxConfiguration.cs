using linxOne.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Configurations
{
   public class TaxConfiguration : IEntityTypeConfiguration<Ib_tax>
    {
        public void Configure(EntityTypeBuilder<Ib_tax> builder)
        {
            builder.ToTable("Ib_taxes");
            builder.HasKey(x => x.Ib_record_primary_key);
            builder.Property(x => x.Ib_tax_name).IsRequired(true);
            builder.Property(x => x.Ib_tax_value).IsRequired(true);

        }
    }
}
