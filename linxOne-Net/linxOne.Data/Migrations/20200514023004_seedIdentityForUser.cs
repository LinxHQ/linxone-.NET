using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace linxOne.Data.Migrations
{
    public partial class seedIdentityForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ARoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Descriptions", "Name", "NormalizedName" },
                values: new object[] { new Guid("9202e66e-3de0-4035-ae69-8850c87ab05a"), "1f9b3efc-28bc-48d8-9131-cd36cdd7817e", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AUser",
                columns: new[] { "Id", "AccessFailedCount", "Birth", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("15d7be41-a49e-4660-82f7-788436d65916"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1983), "95918779-225e-4120-b94c-3eb98b9341d8", "admin@admin.com", true, "david", "silva", false, null, "admin@admin.com", "admin", "AQAAAAEAACcQAAAAEH5JiMDRINod2kxtVewlbxkt45uNVn6dAZ1Il93XJEHPxNluA7DqBIZGs4yr1ZRiYw==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AUserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("15d7be41-a49e-4660-82f7-788436d65916"), new Guid("15d7be41-a49e-4660-82f7-788436d65916") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ARoles",
                keyColumn: "Id",
                keyValue: new Guid("9202e66e-3de0-4035-ae69-8850c87ab05a"));

            migrationBuilder.DeleteData(
                table: "AUser",
                keyColumn: "Id",
                keyValue: new Guid("15d7be41-a49e-4660-82f7-788436d65916"));

            migrationBuilder.DeleteData(
                table: "AUserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("15d7be41-a49e-4660-82f7-788436d65916"), new Guid("15d7be41-a49e-4660-82f7-788436d65916") });
        }
    }
}
