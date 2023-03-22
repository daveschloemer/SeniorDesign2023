using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreshBooks.Migrations
{
    /// <inheritdoc />
    public partial class fshk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookUser_AspNetUsers_UserId",
                table: "BookUser");

            migrationBuilder.DropIndex(
                name: "IX_BookUser_UserId",
                table: "BookUser");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "BookUser",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "BookUser",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_BookUser_UserId",
                table: "BookUser",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookUser_AspNetUsers_UserId",
                table: "BookUser",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
