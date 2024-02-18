using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Batates.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeedingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "ID", "Description", "ImageURL", "Name" },
                values: new object[] { 1, "Italian Food Category 123", "https://i.ibb.co/PZ03P9S/pizza.png", "Italian" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "ID", "ContactNo", "Description", "ImageURL", "Name", "State" },
                values: new object[] { 1, "0114379314", "Roma Pizza for Italian Food!", null, "RomaPizza", 3 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "ExtraDetails", "ImageURL", "Name", "Price", "RestaurantID" },
                values: new object[] { 1, "Best Pizza slice in the world", null, "https://i.ibb.co/PZ03P9S/pizza.png", "One Pizza Slice", 9.99, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
