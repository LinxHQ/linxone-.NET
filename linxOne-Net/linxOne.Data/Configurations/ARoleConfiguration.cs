using linxOne.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Configurations
{
    public class ARoleConfiguration : IEntityTypeConfiguration<ARoles>
    {
        public void Configure(EntityTypeBuilder<ARoles> builder)
        {

            builder.ToTable("ARoles");
            builder.Property(x => x.Descriptions).HasMaxLength(255);
           

        }
    }

}

