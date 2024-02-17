using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Batates.Data.Migrations
{
    /// <inheritdoc />
    public partial class addappuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_ApplicationUser_ApplicationUserID",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ApplicationUser_ApplicationUserID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlists_ApplicationUser_ApplicationUserID",
                table: "Wishlists");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserID",
                table: "Wishlists",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserID",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserID",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CartID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ContactNo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Fullname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_ApplicationUserID",
                table: "Carts",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUserID",
                table: "Orders",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlists_AspNetUsers_ApplicationUserID",
                table: "Wishlists",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_ApplicationUserID",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUserID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlists_AspNetUsers_ApplicationUserID",
                table: "Wishlists");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CartID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ContactNo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Fullname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserID",
                table: "Wishlists",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserID",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserID",
                table: "Carts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CartID = table.Column<int>(type: "int", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_ApplicationUser_ApplicationUserID",
                table: "Carts",
                column: "ApplicationUserID",
                principalTable: "ApplicationUser",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ApplicationUser_ApplicationUserID",
                table: "Orders",
                column: "ApplicationUserID",
                principalTable: "ApplicationUser",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlists_ApplicationUser_ApplicationUserID",
                table: "Wishlists",
                column: "ApplicationUserID",
                principalTable: "ApplicationUser",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
