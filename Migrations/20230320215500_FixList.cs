using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreshBooks.Migrations
{
    /// <inheritdoc />
    public partial class FixList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Listeds");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Listeds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Listeds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Prices",
                table: "ListedItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Listeds");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Listeds");

            migrationBuilder.DropColumn(
                name: "Prices",
                table: "ListedItems");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Listeds",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
