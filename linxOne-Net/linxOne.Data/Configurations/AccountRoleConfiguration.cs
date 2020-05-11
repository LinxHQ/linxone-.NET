using linxOne.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Configurations
{
    public class AccountRoleConfiguration : IEntityTypeConfiguration<Ib_account_role>
    {
        public void Configure(EntityTypeBuilder<Ib_account_role> builder)
        {
            builder.ToTable("Ib_account_roles");
            builder.HasKey(a => new { a.Ib_account_id, a.Ib_role_id });
            builder.HasOne(a => a.Account).WithMany(a => a.Account_Role).HasForeignKey(a=>a.Ib_account_id);
            builder.HasOne(a => a.Role).WithMany(a => a.Role_Account).HasForeignKey(a => a.Ib_role_id);

        }
    }
}
