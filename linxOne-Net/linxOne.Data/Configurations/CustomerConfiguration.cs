using linxOne.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Configurations
{
  public class CustomerConfiguration : IEntityTypeConfiguration<Ib_customer>
    {
        public void Configure(EntityTypeBuilder<Ib_customer> builder)
        {
            builder.ToTable("Ib_customers");
            builder.HasKey(x => x.Ib_record_primary_key);
            builder.Property(x => x.Ib_customer_name).IsRequired(true);
            ;
        }
    }
}
