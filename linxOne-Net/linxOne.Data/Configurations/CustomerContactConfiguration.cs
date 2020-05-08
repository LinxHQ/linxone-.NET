using linxOne.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Configurations
{
  public  class CustomerContactConfiguration : IEntityTypeConfiguration<Ib_customer_contact>
    {
        public void Configure(EntityTypeBuilder<Ib_customer_contact> builder)
        {
            builder.ToTable("Ib_customer_contacts");
            builder.HasKey(x => x.Ib_record_primary_key);
            builder.Property(x => x.Ib_customer_contact_first_name).IsRequired(true);
            builder.Property(x => x.Ib_customer_contact_last_name).IsRequired(true);
        }
    }
}
