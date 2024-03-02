using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Batates.Data.Migrations
{
    /// <inheritdoc />
    public partial class restaurantMapCoords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "locationLat",
                table: "Restaurant",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "locationLong",
                table: "Restaurant",
                type: "real",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2097f2ca-02a2-4b4f-97a0-1a7679151295",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f844950-752b-4293-a977-d838dbac239a", "AQAAAAIAAYagAAAAEEvaiiv//Byp+gDiMDX6OAnHIqxIpWS6Q3Jz0kM8uku35sp86EYi4m7exqr6Rn5xQw==", "2a99de48-8305-4b8f-ad98-ed72d7996f3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "279152a8-7bb3-4cd8-9819-ecb1f09aaef4", "AQAAAAIAAYagAAAAEC/7EW6pkaAh71UVkZa11QQQz0t7DvsPsNzWr8WtWuBijmkXv8CZyKwsm3MnWnoVWA==", "d4d6b007-7ca3-49cd-b9ca-87d0de97de10" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "locationLat", "locationLong" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "locationLat",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "locationLong",
                table: "Restaurant");

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
        }
    }
}
