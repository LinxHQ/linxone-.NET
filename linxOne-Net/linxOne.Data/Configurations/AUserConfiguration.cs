using linxOne.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Configurations
{
    public class AUserConfiguration : IEntityTypeConfiguration<AUser>
    {
        public void Configure(EntityTypeBuilder<AUser> builder)
        {
            builder.ToTable("AUser");
            builder.Property(x => x.FirstName).IsRequired(true);
            
        }
    }
}
