using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace linxOne.Data.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ARoles",
                keyColumn: "Id",
                keyValue: new Guid("9202e66e-3de0-4035-ae69-8850c87ab05a"),
                column: "ConcurrencyStamp",
                value: "e124f434-2c70-4dff-b66a-bdf029ce76d9");

            migrationBuilder.UpdateData(
                table: "AUser",
                keyColumn: "Id",
                keyValue: new Guid("15d7be41-a49e-4660-82f7-788436d65916"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7132dd21-4121-4df5-8b91-e654e04e545b", "AQAAAAEAACcQAAAAECa3jdMOL7o4YEjPsh6ni2jEelyhYH/XZZUrRtIRgT5g//8KaETyToFDJfqQfnp0Qg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ARoles",
                keyColumn: "Id",
                keyValue: new Guid("9202e66e-3de0-4035-ae69-8850c87ab05a"),
                column: "ConcurrencyStamp",
                value: "0634ab9c-4895-4596-b497-ce0cb863a9ae");

            migrationBuilder.UpdateData(
                table: "AUser",
                keyColumn: "Id",
                keyValue: new Guid("15d7be41-a49e-4660-82f7-788436d65916"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "27bc2352-8005-4779-a864-91deb51089c0", "AQAAAAEAACcQAAAAEAkpyxJ9bkKfcQnb2s4M+7IaubHQB8xgbA4Nsof7MuSPPuFCRclXlOE4FACBo7QczQ==" });
        }
    }
}
