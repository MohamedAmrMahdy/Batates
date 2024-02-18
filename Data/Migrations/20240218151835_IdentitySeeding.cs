using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Batates.Data.Migrations
{
    /// <inheritdoc />
    public partial class IdentitySeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", null, "Admin", "ADMIN" },
                    { "d3c902cf-6b3e-4f66-9b82-c6a18a4ffa13", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "CartID", "ConcurrencyStamp", "ContactNo", "Email", "EmailConfirmed", "Fullname", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2097f2ca-02a2-4b4f-97a0-1a7679151295", 0, null, 0, "383a86c1-4792-43b0-816e-ac3ad22ab020", null, "customer@batates.com", true, null, null, false, null, "CUSTOMER@BATATES.COM", "CUSTOMER@BATATES", "AQAAAAIAAYagAAAAEH1wWHkfRE9ggQirayNuMYvEYWSs2qYlGtYWNrnRaytH2blJwiBNbK4fBab1KtOffA==", null, false, "cfc2ce35-9961-4d3b-aef9-f5284798596b", false, "customer@batates.com" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, null, 0, "92d6c69f-5742-4ad1-9a20-c336b00ea1bd", null, "admin@batates.com", true, null, null, false, null, "ADMIN@BATATES.COM", "ADMIN@BATATES", "AQAAAAIAAYagAAAAEFczWwtRKBY20A1hc46+kW8L77jGtXDj1fB5C3jwsOqaoG/MJsWVysdM9lwFQGgFFw==", null, false, "6899be3f-9b2c-4a21-900d-200bc9bb8268", false, "admin@batates.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d3c902cf-6b3e-4f66-9b82-c6a18a4ffa13", "2097f2ca-02a2-4b4f-97a0-1a7679151295" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d3c902cf-6b3e-4f66-9b82-c6a18a4ffa13", "2097f2ca-02a2-4b4f-97a0-1a7679151295" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3c902cf-6b3e-4f66-9b82-c6a18a4ffa13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2097f2ca-02a2-4b4f-97a0-1a7679151295");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");
        }
    }
}
