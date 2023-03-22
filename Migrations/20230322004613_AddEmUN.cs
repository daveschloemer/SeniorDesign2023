using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreshBooks.Migrations
{
    /// <inheritdoc />
    public partial class AddEmUN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
           
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Book");
        }
    }
}
