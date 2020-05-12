using linxOne.Data.Entities;
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
        }
    }
}
