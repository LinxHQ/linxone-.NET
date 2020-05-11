using linxOne.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Configurations
{
   public class AccountConfiguration : IEntityTypeConfiguration<Ib_account>
    {
        public void Configure(EntityTypeBuilder<Ib_account> builder)
        {
            builder.ToTable("Ib_accounts");
            builder.HasKey(x => x.Ib_record_primary_key);
            builder.Property(x => x.Ib_account_username).IsRequired(true);
            builder.Property(x => x.Ib_account_password).IsRequired(true);

        }
    }
}
