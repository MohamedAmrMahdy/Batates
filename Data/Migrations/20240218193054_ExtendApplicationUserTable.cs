using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Batates.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendApplicationUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactNo",
                table: "AspNetUsers",
                newName: "StreetAddress");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "AspNetUsers",
                newName: "State");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2097f2ca-02a2-4b4f-97a0-1a7679151295",
                columns: new[] { "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "5d4f1a2e-548e-4545-8c8f-f4a9d0224f2f", "AQAAAAIAAYagAAAAEPmkYuDzQLwSECRk45bR41vGeEPYFOdcWN2m2a88Mp3UdQBDbx6V44ailJqb1Fu2Ng==", "6d055753-d7a5-4539-9940-d0772bc62030" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "City", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "802fc19f-d661-4889-843b-7d04bbe2a270", "AQAAAAIAAYagAAAAEHGo1cmqtmLNEjdEwXWhGNIOegAHUR+uGAL++QZV2GAhcPFweLqy+uxRbKWgf8HMkA==", "f9a32026-2a05-40a7-b65b-29a8b42850e5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "AspNetUsers",
                newName: "ContactNo");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "AspNetUsers",
                newName: "Address");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2097f2ca-02a2-4b4f-97a0-1a7679151295",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "383a86c1-4792-43b0-816e-ac3ad22ab020", "AQAAAAIAAYagAAAAEH1wWHkfRE9ggQirayNuMYvEYWSs2qYlGtYWNrnRaytH2blJwiBNbK4fBab1KtOffA==", "cfc2ce35-9961-4d3b-aef9-f5284798596b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92d6c69f-5742-4ad1-9a20-c336b00ea1bd", "AQAAAAIAAYagAAAAEFczWwtRKBY20A1hc46+kW8L77jGtXDj1fB5C3jwsOqaoG/MJsWVysdM9lwFQGgFFw==", "6899be3f-9b2c-4a21-900d-200bc9bb8268" });
        }
    }
}
