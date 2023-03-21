using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreshBooks.Migrations
{
    /// <inheritdoc />
    public partial class User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListedItems");

            migrationBuilder.DropTable(
                name: "Listeds");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Listeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listeds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListedItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    ListedId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListedItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListedItems_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListedItems_Listeds_ListedId",
                        column: x => x.ListedId,
                        principalTable: "Listeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListedItems_BookId",
                table: "ListedItems",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_ListedItems_ListedId",
                table: "ListedItems",
                column: "ListedId");
        }
    }
}
