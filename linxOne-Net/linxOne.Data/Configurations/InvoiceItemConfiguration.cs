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

            builder.HasOne(x=>x.Product).WithMany(x=>x.Invoice_Item_Product).HasForeignKey(x=>x.Ib_invoice_product_id);
            builder.HasOne(x => x.Invoice).WithMany(x => x.Invoice_Item_Inv).HasForeignKey(x => x.Ib_invoice_id);



        }
    }
}
