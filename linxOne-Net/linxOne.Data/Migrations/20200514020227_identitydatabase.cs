using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace linxOne.Data.Migrations
{
    public partial class identitydatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Ib_customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Ib_customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Ib_customers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Ib_customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Ib_customers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Ib_customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Ib_customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Ib_customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Ib_customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Ib_customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Ib_customers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Ib_customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Ib_customers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Ib_customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Ib_customers",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UseId",
                table: "Ib_customer_contacts",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ARoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARoleClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ARoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Descriptions = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Birth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AUserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUserClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AUserLogin",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUserLogin", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AUserRole",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUserRole", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AUserToken",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUserToken", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ARoleClaim");

            migrationBuilder.DropTable(
                name: "ARoles");

            migrationBuilder.DropTable(
                name: "AUser");

            migrationBuilder.DropTable(
                name: "AUserClaim");

            migrationBuilder.DropTable(
                name: "AUserLogin");

            migrationBuilder.DropTable(
                name: "AUserRole");

            migrationBuilder.DropTable(
                name: "AUserToken");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Ib_customers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Ib_customers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Ib_customers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Ib_customers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Ib_customers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Ib_customers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Ib_customers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Ib_customers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Ib_customers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Ib_customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Ib_customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Ib_customers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Ib_customers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Ib_customers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Ib_customers");

            migrationBuilder.DropColumn(
                name: "UseId",
                table: "Ib_customer_contacts");
        }
    }
}
