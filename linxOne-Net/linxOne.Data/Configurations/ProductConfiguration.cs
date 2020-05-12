using linxOne.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Ib_product>
    {
        public void Configure(EntityTypeBuilder<Ib_product> builder)
        {
            builder.ToTable("Ib_products");
            builder.HasKey(x => x.Ib_record_primary_key);


            
        }
    }
}
