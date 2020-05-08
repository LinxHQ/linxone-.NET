using linxOne.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Configurations
{
    public class InvoiceItemConfiguration : IEntityTypeConfiguration<Ib_invoice_item>
    {
        public void Configure(EntityTypeBuilder<Ib_invoice_item> builder)
        {
            builder.ToTable("Ib_invoice_items");
            builder.HasKey(x => x.Ib_record_primary_key);
            builder.Property(x => x.Ib_invoice_item_quantity).HasDefaultValue(1);
        }
    }
}
