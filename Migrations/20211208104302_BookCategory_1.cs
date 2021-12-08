using Microsoft.EntityFrameworkCore.Migrations;

namespace Cosma_Andreea_Lab8.Migrations
{
    public partial class BookCategory_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_Book_BookID1",
                table: "BookCategory");

            migrationBuilder.DropIndex(
                name: "IX_BookCategory_BookID1",
                table: "BookCategory");

            migrationBuilder.DropColumn(
                name: "BookID1",
                table: "BookCategory");

            migrationBuilder.AlterColumn<int>(
                name: "BookID",
                table: "BookCategory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Book",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Book",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookCategory_BookID",
                table: "BookCategory",
                column: "BookID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_Book_BookID",
                table: "BookCategory",
                column: "BookID",
                principalTable: "Book",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_Book_BookID",
                table: "BookCategory");

            migrationBuilder.DropIndex(
                name: "IX_BookCategory_BookID",
                table: "BookCategory");

            migrationBuilder.AlterColumn<string>(
                name: "BookID",
                table: "BookCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BookID1",
                table: "BookCategory",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_BookCategory_BookID1",
                table: "BookCategory",
                column: "BookID1");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_Book_BookID1",
                table: "BookCategory",
                column: "BookID1",
                principalTable: "Book",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
