using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Batates.Data.Migrations
{
    /// <inheritdoc />
    public partial class RestaurantRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Restaurant",
                type: "float",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2097f2ca-02a2-4b4f-97a0-1a7679151295",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cec61c8-cf8d-4e3c-a47a-3bce5f3ab88c", "AQAAAAIAAYagAAAAECcE542/Lh2LzeNcO2Tq4p0dO7tKRKdBnwTNEH1yffRI06oGMNVzX22ROQswflBZGg==", "3992378f-f48b-4481-9cd9-195982e917f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ce61424-341f-4aa4-b03f-a17743f5418f", "AQAAAAIAAYagAAAAEGtGphzOE+WNMJZmmUDV4Z/M4KMWyv8b+AATnfllo/oam+MKlvcbPZ+1t0Q/nOSB4A==", "89840733-70f7-4720-9a8c-f7b1d9dd8b26" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 1,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 2,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 3,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 4,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 5,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 6,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 7,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 8,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 9,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 10,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 11,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 12,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 13,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 14,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 15,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 16,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 17,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 18,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 19,
                column: "Rating",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 20,
                column: "Rating",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Restaurant");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2097f2ca-02a2-4b4f-97a0-1a7679151295",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "450b1ef2-1859-4242-a395-9d67c24d3ad4", "AQAAAAIAAYagAAAAEErMcJC5qRz7VdNyxuYBr3CAzD0I/kS/TBBAXxs9frhjB66dX27V4pS2eRMijm0PnA==", "b8414d85-5199-49ca-8a4e-9cb2efe2f44d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ce08834-cb78-450a-b886-2ad79d010dc6", "AQAAAAIAAYagAAAAELXxDzWyUojni1dXdGN0V7YjEb0Wa9LKTbPW0EZcGE1oOU3hQGwm+AtQ3QiLWanzqw==", "50a4f49b-2743-48e4-bb59-31ba7490f0f6" });
        }
    }
}
