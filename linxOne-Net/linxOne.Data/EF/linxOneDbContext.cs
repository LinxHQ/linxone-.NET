﻿using linxOne.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.EF
{
    class linxOneDbContext :DbContext 
    {
        public linxOneDbContext(DbContextOptions options) :base(options)
        {
            

        }
        public DbSet<Ib_address> Ib_addresses { get; set; }
        public DbSet<Ib_account> Ib_accounts { get; set; }
        public DbSet<Ib_account_role> Ib_account_roles { get; set; }
        public DbSet<Ib_customer> Ib_customers { get; set; }
        public DbSet<Ib_customer_contact> Ib_customer_contacts { get; set; }
        public DbSet<Ib_invoice> Ib_invoices { get; set; }
        public DbSet<Ib_invoice_item> Ib_invoice_items { get; set; }
        public DbSet<Ib_payment> Ib_payments { get; set; }
        public DbSet<Ib_product> Ib_products { get; set; }
        public DbSet<Ib_role> Ib_roles { get; set; }
        public DbSet<Ib_tax> Ib_taxes { get; set; }

    }
}
