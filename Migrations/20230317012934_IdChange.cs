using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreshBooks.Migrations
{
    /// <inheritdoc />
    public partial class IdChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Book",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Book",
                newName: "BookId");
        }
    }
}
