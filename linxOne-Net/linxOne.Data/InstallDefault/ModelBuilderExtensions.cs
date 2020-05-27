using linxOne.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.InstallDefault
{
  public static  class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Ib_tax>().HasData(

               new Ib_tax() { Ib_record_primary_key= 01,Ib_tax_name = "FL", Ib_tax_value = "6.50" },
               new Ib_tax() { Ib_record_primary_key = 02, Ib_tax_name = "VAT", Ib_tax_value = "14.00" },
               new Ib_tax() { Ib_record_primary_key = 03, Ib_tax_name = "TGST", Ib_tax_value = "5.00" },
               new Ib_tax() { Ib_record_primary_key = 04, Ib_tax_name = "GST%", Ib_tax_value = "5.00" },
               new Ib_tax() { Ib_record_primary_key = 05, Ib_tax_name = "GST 17%", Ib_tax_value = "5.00" },
               new Ib_tax() { Ib_record_primary_key = 06, Ib_tax_name = "IVA2", Ib_tax_value = "16.00" },
               new Ib_tax() { Ib_record_primary_key = 07, Ib_tax_name = "IVA", Ib_tax_value = "13.00" }

            );


            var ADMIN_ID = new Guid ("15D7BE41-A49E-4660-82F7-788436D65916");
            // any guid, but nothing is against to use the same one
            var ROLE_ID = ADMIN_ID;
            modelBuilder.Entity<ARoles>().HasData(new ARoles
            {
                Id = new Guid("9202E66E-3DE0-4035-AE69-8850C87AB05A"),
                Name = "admin",
                NormalizedName = "admin",
                Descriptions ="Administrator role"
            });

            var hasher = new PasswordHasher<AUser>();
            modelBuilder.Entity<AUser>().HasData(new AUser
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@admin.com",
                NormalizedEmail = "admin@admin.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin123"),
                SecurityStamp = string.Empty,
                FirstName = "david",
                LastName= "silva",
                Birth= new DateTime(1991-05-03) 
            }); ;

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}
