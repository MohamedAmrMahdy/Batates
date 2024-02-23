using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Batates.Data.Migrations
{
    /// <inheritdoc />
    public partial class orderUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2097f2ca-02a2-4b4f-97a0-1a7679151295",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4acbd9d7-a01f-46a0-be12-1de459cd7212", "AQAAAAIAAYagAAAAEMfOLfljSVdBFRzd3G7NvRqmhJgRZEOibnM7tLqhGHrhPG6MskKzjzFecELMF2FQXw==", "bbcf8bc7-6ec3-4829-818c-e2a26236fb48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de2fcd83-b09c-466d-aacd-10459e01719a", "AQAAAAIAAYagAAAAEAdc9jXD8DMyb2LAEL4AD4K0iBqu882klfZlzd+5gr2YXf5YAZCOZ7pztbMjEWK8gw==", "e38bf7c5-e9a5-4cb1-9b38-b07fd3963d74" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2097f2ca-02a2-4b4f-97a0-1a7679151295",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2873a2c8-7485-4473-9dfe-5e51ac0cd123", "AQAAAAIAAYagAAAAENWiBqTuCpcOgKyGMPI4aiW3zzL8pPhonIAc8dXLZglNHhwRghSo0Akjxdo4lqIbyA==", "f10fc074-d88a-4e3f-93e4-59eb5e71f75c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad6a50f6-6a25-4333-9a5f-4d711baf13ea", "AQAAAAIAAYagAAAAEFxsX8a1SXs0lOYgazzSdgFImTad1nRLmwzhcnm/4wG3v+9JhC8tPFteoN2gp+IfeQ==", "366f00af-f16f-4f4b-ba90-7489ab9606a4" });
        }
    }
}
