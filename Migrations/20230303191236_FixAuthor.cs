using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreshBooks.Migrations
{
    /// <inheritdoc />
    public partial class FixAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Authors",
                table: "Book");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Authors",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
