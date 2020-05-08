using linxOne.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Configurations
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Ib_invoice>
    {
        public void Configure(EntityTypeBuilder<Ib_invoice> builder)
        {
            builder.ToTable("Ib_invoices");
            builder.HasKey(x => x.Ib_record_primary_key);

        }
    }
}
