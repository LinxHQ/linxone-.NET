using linxOne.Data.Configurations;
using linxOne.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.EF
{
    public class linxOneDbContext : DbContext
    {
        public linxOneDbContext(DbContextOptions options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new TaxConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerContactConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new AccountRoleConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceItemConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            // base.OnModelCreating(modelBuilder);
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
