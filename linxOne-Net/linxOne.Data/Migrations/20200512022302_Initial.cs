using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace linxOne.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ib_accounts",
                columns: table => new
                {
                    Ib_record_primary_key = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ib_account_password = table.Column<string>(nullable: false),
                    Ib_account_username = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ib_accounts", x => x.Ib_record_primary_key);
                });

            migrationBuilder.CreateTable(
                name: "Ib_customers",
                columns: table => new
                {
                    Ib_record_primary_key = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ib_customer_name = table.Column<string>(nullable: false),
                    Ib_customer_registration = table.Column<string>(nullable: true),
                    Ib_customer_type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ib_customers", x => x.Ib_record_primary_key);
                });

            migrationBuilder.CreateTable(
                name: "Ib_products",
                columns: table => new
                {
                    Ib_record_primary_key = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ib_product_description = table.Column<string>(nullable: true),
                    Ib_product_name = table.Column<string>(nullable: true),
                    Ib_product_price = table.Column<double>(nullable: false),
                    Ib_product_tax = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ib_products", x => x.Ib_record_primary_key);
                });

            migrationBuilder.CreateTable(
                name: "Ib_roles",
                columns: table => new
                {
                    Ib_record_primary_key = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ib_role_name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ib_roles", x => x.Ib_record_primary_key);
                });

            migrationBuilder.CreateTable(
                name: "Ib_taxes",
                columns: table => new
                {
                    Ib_record_primary_key = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ib_tax_name = table.Column<string>(nullable: false),
                    Ib_tax_value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ib_taxes", x => x.Ib_record_primary_key);
                });

            migrationBuilder.CreateTable(
                name: "Ib_addresses",
                columns: table => new
                {
                    Ib_record_primary_key = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ib_customer_address_city = table.Column<string>(nullable: true),
                    Ib_customer_address_line_1 = table.Column<string>(nullable: false),
                    Ib_customer_address_line_2 = table.Column<string>(nullable: true),
                    Ib_customer_address_phone_1 = table.Column<string>(nullable: true),
                    Ib_customer_address_phone_2 = table.Column<string>(nullable: true),
                    Ib_customer_address_postal_code = table.Column<string>(nullable: true),
                    Ib_customer_address_state = table.Column<string>(nullable: true),
                    Ib_customer_address_website_url = table.Column<string>(nullable: true),
                    Ib_customer_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ib_addresses", x => x.Ib_record_primary_key);
                    table.ForeignKey(
                        name: "FK_Ib_addresses_Ib_customers_Ib_customer_id",
                        column: x => x.Ib_customer_id,
                        principalTable: "Ib_customers",
                        principalColumn: "Ib_record_primary_key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ib_customer_contacts",
                columns: table => new
                {
                    Ib_record_primary_key = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ib_customer_contact_email_1 = table.Column<string>(nullable: true),
                    Ib_customer_contact_email_2 = table.Column<string>(nullable: true),
                    Ib_customer_contact_first_name = table.Column<string>(nullable: false),
                    Ib_customer_contact_last_name = table.Column<string>(nullable: false),
                    Ib_customer_contact_mobile = table.Column<string>(nullable: true),
                    Ib_customer_contact_note = table.Column<string>(nullable: true),
                    Ib_customer_contact_office_fax = table.Column<string>(nullable: true),
                    Ib_customer_contact_office_phone = table.Column<string>(nullable: true),
                    Ib_customer_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ib_customer_contacts", x => x.Ib_record_primary_key);
                    table.ForeignKey(
                        name: "FK_Ib_customer_contacts_Ib_customers_Ib_customer_id",
                        column: x => x.Ib_customer_id,
                        principalTable: "Ib_customers",
                        principalColumn: "Ib_record_primary_key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ib_invoices",
                columns: table => new
                {
                    Ib_record_primary_key = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ib_invoice_customer_id = table.Column<int>(nullable: false),
                    Ib_invoice_date = table.Column<DateTime>(nullable: false),
                    Ib_invoice_due_date = table.Column<DateTime>(nullable: false),
                    Ib_invoice_encode = table.Column<string>(nullable: true),
                    Ib_invoice_no = table.Column<string>(nullable: true),
                    Ib_invoice_note = table.Column<string>(nullable: true),
                    Ib_invoice_subject = table.Column<string>(nullable: true),
                    Ib_invoice_subtotal = table.Column<float>(nullable: false),
                    Ib_invoice_total_after_discounts = table.Column<float>(nullable: false),
                    Ib_invoice_total_after_taxes = table.Column<float>(nullable: false),
                    Ib_invoice_total_outstanding = table.Column<float>(nullable: false),
                    Ib_invoice_total_paid = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ib_invoices", x => x.Ib_record_primary_key);
                    table.ForeignKey(
                        name: "FK_Ib_invoices_Ib_customers_Ib_invoice_customer_id",
                        column: x => x.Ib_invoice_customer_id,
                        principalTable: "Ib_customers",
                        principalColumn: "Ib_record_primary_key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ib_account_roles",
                columns: table => new
                {
                    Ib_account_id = table.Column<int>(nullable: false),
                    Ib_role_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ib_account_roles", x => new { x.Ib_account_id, x.Ib_role_id });
                    table.ForeignKey(
                        name: "FK_Ib_account_roles_Ib_accounts_Ib_account_id",
                        column: x => x.Ib_account_id,
                        principalTable: "Ib_accounts",
                        principalColumn: "Ib_record_primary_key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ib_account_roles_Ib_roles_Ib_role_id",
                        column: x => x.Ib_role_id,
                        principalTable: "Ib_roles",
                        principalColumn: "Ib_record_primary_key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ib_invoice_items",
                columns: table => new
                {
                    Ib_record_primary_key = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ib_invoice_product_id = table.Column<int>(nullable: false),
                    Ib_invoice_id = table.Column<int>(nullable: false),
                    Ib_invoice_item_quantity = table.Column<float>(nullable: false, defaultValue: 1f),
                    Ib_invoice_item_tota = table.Column<float>(nullable: false),
                    Ib_invoice_item_value = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ib_invoice_items", x => x.Ib_record_primary_key);
                    table.ForeignKey(
                        name: "FK_Ib_invoice_items_Ib_invoices_Ib_invoice_id",
                        column: x => x.Ib_invoice_id,
                        principalTable: "Ib_invoices",
                        principalColumn: "Ib_record_primary_key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ib_invoice_items_Ib_products_Ib_invoice_product_id",
                        column: x => x.Ib_invoice_product_id,
                        principalTable: "Ib_products",
                        principalColumn: "Ib_record_primary_key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ib_payments",
                columns: table => new
                {
                    Ib_record_primary_key = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ib_amount = table.Column<float>(nullable: false),
                    Ib_date = table.Column<DateTime>(nullable: false),
                    Ib_Method = table.Column<string>(nullable: true),
                    Ib_no = table.Column<string>(nullable: true),
                    Ib_note = table.Column<string>(nullable: true),
                    Ib_invoice_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ib_payments", x => x.Ib_record_primary_key);
                    table.ForeignKey(
                        name: "FK_Ib_payments_Ib_invoices_Ib_invoice_id",
                        column: x => x.Ib_invoice_id,
                        principalTable: "Ib_invoices",
                        principalColumn: "Ib_record_primary_key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ib_account_roles_Ib_role_id",
                table: "Ib_account_roles",
                column: "Ib_role_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ib_addresses_Ib_customer_id",
                table: "Ib_addresses",
                column: "Ib_customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ib_customer_contacts_Ib_customer_id",
                table: "Ib_customer_contacts",
                column: "Ib_customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ib_invoice_items_Ib_invoice_id",
                table: "Ib_invoice_items",
                column: "Ib_invoice_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ib_invoice_items_Ib_invoice_product_id",
                table: "Ib_invoice_items",
                column: "Ib_invoice_product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ib_invoices_Ib_invoice_customer_id",
                table: "Ib_invoices",
                column: "Ib_invoice_customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ib_payments_Ib_invoice_id",
                table: "Ib_payments",
                column: "Ib_invoice_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ib_account_roles");

            migrationBuilder.DropTable(
                name: "Ib_addresses");

            migrationBuilder.DropTable(
                name: "Ib_customer_contacts");

            migrationBuilder.DropTable(
                name: "Ib_invoice_items");

            migrationBuilder.DropTable(
                name: "Ib_payments");

            migrationBuilder.DropTable(
                name: "Ib_taxes");

            migrationBuilder.DropTable(
                name: "Ib_accounts");

            migrationBuilder.DropTable(
                name: "Ib_roles");

            migrationBuilder.DropTable(
                name: "Ib_products");

            migrationBuilder.DropTable(
                name: "Ib_invoices");

            migrationBuilder.DropTable(
                name: "Ib_customers");
        }
    }
}
