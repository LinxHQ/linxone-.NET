﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using linxOne.Data.EF;

namespace linxOne.Data.Migrations
{
    [DbContext(typeof(linxOneDbContext))]
    [Migration("20200514020630_aspNetcoreIdentityDatabase")]
    partial class aspNetcoreIdentityDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("ARoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AUserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AUserLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AUserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AUserToken");
                });

            modelBuilder.Entity("linxOne.Data.Entities.ARoles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descriptions")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ARoles");
                });

            modelBuilder.Entity("linxOne.Data.Entities.AUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AUser");
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_account", b =>
                {
                    b.Property<int>("Ib_record_primary_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ib_account_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_account_username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ib_record_primary_key");

                    b.ToTable("Ib_accounts");
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_account_role", b =>
                {
                    b.Property<int>("Ib_account_id")
                        .HasColumnType("int");

                    b.Property<int>("Ib_role_id")
                        .HasColumnType("int");

                    b.HasKey("Ib_account_id", "Ib_role_id");

                    b.HasIndex("Ib_role_id");

                    b.ToTable("Ib_account_roles");
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_address", b =>
                {
                    b.Property<int>("Ib_record_primary_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ib_customer_address_city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_address_line_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_address_line_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_address_phone_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_address_phone_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_address_postal_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_address_state")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_address_website_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ib_customer_id")
                        .HasColumnType("int");

                    b.HasKey("Ib_record_primary_key");

                    b.HasIndex("Ib_customer_id");

                    b.ToTable("Ib_addresses");
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_customer", b =>
                {
                    b.Property<int>("Ib_record_primary_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Ib_customer_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_registration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ib_record_primary_key");

                    b.ToTable("Ib_customers");
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_customer_contact", b =>
                {
                    b.Property<int>("Ib_record_primary_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ib_customer_contact_email_1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_contact_email_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_contact_first_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_contact_last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_contact_mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_contact_note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_contact_office_fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_customer_contact_office_phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ib_customer_id")
                        .HasColumnType("int");

                    b.Property<Guid>("UseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Ib_record_primary_key");

                    b.HasIndex("Ib_customer_id");

                    b.ToTable("Ib_customer_contacts");
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_invoice", b =>
                {
                    b.Property<int>("Ib_record_primary_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ib_invoice_customer_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ib_invoice_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ib_invoice_due_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ib_invoice_encode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_invoice_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_invoice_note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_invoice_subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Ib_invoice_subtotal")
                        .HasColumnType("real");

                    b.Property<float>("Ib_invoice_total_after_discounts")
                        .HasColumnType("real");

                    b.Property<float>("Ib_invoice_total_after_taxes")
                        .HasColumnType("real");

                    b.Property<float>("Ib_invoice_total_outstanding")
                        .HasColumnType("real");

                    b.Property<float>("Ib_invoice_total_paid")
                        .HasColumnType("real");

                    b.HasKey("Ib_record_primary_key");

                    b.HasIndex("Ib_invoice_customer_id");

                    b.ToTable("Ib_invoices");
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_invoice_item", b =>
                {
                    b.Property<int>("Ib_record_primary_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ib_invoice_id")
                        .HasColumnType("int");

                    b.Property<float>("Ib_invoice_item_quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("real")
                        .HasDefaultValue(1f);

                    b.Property<float>("Ib_invoice_item_tota")
                        .HasColumnType("real");

                    b.Property<float>("Ib_invoice_item_value")
                        .HasColumnType("real");

                    b.Property<int>("Ib_invoice_product_id")
                        .HasColumnType("int");

                    b.HasKey("Ib_record_primary_key");

                    b.HasIndex("Ib_invoice_id");

                    b.HasIndex("Ib_invoice_product_id");

                    b.ToTable("Ib_invoice_items");
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_payment", b =>
                {
                    b.Property<int>("Ib_record_primary_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ib_Method")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Ib_amount")
                        .HasColumnType("real");

                    b.Property<DateTime>("Ib_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ib_invoice_id")
                        .HasColumnType("int");

                    b.Property<string>("Ib_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ib_record_primary_key");

                    b.HasIndex("Ib_invoice_id");

                    b.ToTable("Ib_payments");
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_product", b =>
                {
                    b.Property<int>("Ib_record_primary_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ib_product_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_product_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Ib_product_price")
                        .HasColumnType("float");

                    b.Property<decimal>("Ib_product_tax")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Ib_record_primary_key");

                    b.ToTable("Ib_products");
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_role", b =>
                {
                    b.Property<int>("Ib_record_primary_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ib_role_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ib_record_primary_key");

                    b.ToTable("Ib_roles");
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_tax", b =>
                {
                    b.Property<int>("Ib_record_primary_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ib_tax_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ib_tax_value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ib_record_primary_key");

                    b.ToTable("Ib_taxes");

                    b.HasData(
                        new
                        {
                            Ib_record_primary_key = 1,
                            Ib_tax_name = "FL",
                            Ib_tax_value = "6.50"
                        },
                        new
                        {
                            Ib_record_primary_key = 2,
                            Ib_tax_name = "VAT",
                            Ib_tax_value = "14.00"
                        },
                        new
                        {
                            Ib_record_primary_key = 3,
                            Ib_tax_name = "TGST",
                            Ib_tax_value = "5.00"
                        },
                        new
                        {
                            Ib_record_primary_key = 4,
                            Ib_tax_name = "GST%",
                            Ib_tax_value = "5.00"
                        },
                        new
                        {
                            Ib_record_primary_key = 5,
                            Ib_tax_name = "GST 17%",
                            Ib_tax_value = "5.00"
                        },
                        new
                        {
                            Ib_record_primary_key = 6,
                            Ib_tax_name = "IVA2",
                            Ib_tax_value = "16.00"
                        },
                        new
                        {
                            Ib_record_primary_key = 7,
                            Ib_tax_name = "IVA",
                            Ib_tax_value = "13.00"
                        });
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_account_role", b =>
                {
                    b.HasOne("linxOne.Data.Entities.Ib_account", "Account")
                        .WithMany("Account_Role")
                        .HasForeignKey("Ib_account_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("linxOne.Data.Entities.Ib_role", "Role")
                        .WithMany("Role_Account")
                        .HasForeignKey("Ib_role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_address", b =>
                {
                    b.HasOne("linxOne.Data.Entities.Ib_customer", "Customer")
                        .WithMany("Customer_Address")
                        .HasForeignKey("Ib_customer_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_customer_contact", b =>
                {
                    b.HasOne("linxOne.Data.Entities.Ib_customer", "Customer")
                        .WithMany("Customer_Contact")
                        .HasForeignKey("Ib_customer_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_invoice", b =>
                {
                    b.HasOne("linxOne.Data.Entities.Ib_customer", "Customer")
                        .WithMany("Customer_Invoice")
                        .HasForeignKey("Ib_invoice_customer_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_invoice_item", b =>
                {
                    b.HasOne("linxOne.Data.Entities.Ib_invoice", "Invoice")
                        .WithMany("Invoice_Item_Inv")
                        .HasForeignKey("Ib_invoice_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("linxOne.Data.Entities.Ib_product", "Product")
                        .WithMany("Invoice_Item_Product")
                        .HasForeignKey("Ib_invoice_product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("linxOne.Data.Entities.Ib_payment", b =>
                {
                    b.HasOne("linxOne.Data.Entities.Ib_invoice", "Invoice")
                        .WithMany("Invoice_Payment")
                        .HasForeignKey("Ib_invoice_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
