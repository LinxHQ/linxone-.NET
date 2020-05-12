using Microsoft.EntityFrameworkCore.Migrations;

namespace linxOne.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ib_taxes",
                columns: new[] { "Ib_record_primary_key", "Ib_tax_name", "Ib_tax_value" },
                values: new object[,]
                {
                    { 1, "FL", "6.50" },
                    { 2, "VAT", "14.00" },
                    { 3, "TGST", "5.00" },
                    { 4, "GST%", "5.00" },
                    { 5, "GST 17%", "5.00" },
                    { 6, "IVA2", "16.00" },
                    { 7, "IVA", "13.00" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ib_taxes",
                keyColumn: "Ib_record_primary_key",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ib_taxes",
                keyColumn: "Ib_record_primary_key",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ib_taxes",
                keyColumn: "Ib_record_primary_key",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ib_taxes",
                keyColumn: "Ib_record_primary_key",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ib_taxes",
                keyColumn: "Ib_record_primary_key",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ib_taxes",
                keyColumn: "Ib_record_primary_key",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ib_taxes",
                keyColumn: "Ib_record_primary_key",
                keyValue: 7);
        }
    }
}
