using linxOne.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Ib_address>
    {
        public void Configure(EntityTypeBuilder<Ib_address> builder)
        {
            builder.ToTable("Ib_addresses");
            builder.HasKey(x => x.Ib_record_primary_key);
            builder.Property(x => x.Ib_customer_address_line_1).IsRequired(true);

        }
    }
}
