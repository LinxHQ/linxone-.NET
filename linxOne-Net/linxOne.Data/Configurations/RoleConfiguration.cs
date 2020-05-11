using linxOne.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Ib_role>

    {
        public void Configure(EntityTypeBuilder<Ib_role> builder)
        {
            builder.ToTable("Ib_roles");
            builder.HasKey(x => x.Ib_record_primary_key);
            builder.Property(x => x.Ib_role_name).IsRequired(true);
        }
    }
}
