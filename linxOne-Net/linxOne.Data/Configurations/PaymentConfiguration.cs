using linxOne.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Ib_payment>
    {
        public void Configure(EntityTypeBuilder<Ib_payment> builder)
        {
            builder.ToTable("Ib_payments");
            builder.HasKey(x => x.Ib_record_primary_key);
            builder.Property(x => x.Ib_amount).IsRequired(true);
        }
    }
}
