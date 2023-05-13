using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectFinal.Migrations
{
    public partial class NameFixBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ABooks_PublishingHouses_PublishingHouseId",
                table: "ABooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Books_ABooks_BookId",
                table: "Authors_Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ABooks",
                table: "ABooks");

            migrationBuilder.RenameTable(
                name: "ABooks",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_ABooks_PublishingHouseId",
                table: "Books",
                newName: "IX_Books_PublishingHouseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Books_Books_BookId",
                table: "Authors_Books",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_PublishingHouses_PublishingHouseId",
                table: "Books",
                column: "PublishingHouseId",
                principalTable: "PublishingHouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Books_Books_BookId",
                table: "Authors_Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_PublishingHouses_PublishingHouseId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "ABooks");

            migrationBuilder.RenameIndex(
                name: "IX_Books_PublishingHouseId",
                table: "ABooks",
                newName: "IX_ABooks_PublishingHouseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ABooks",
                table: "ABooks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ABooks_PublishingHouses_PublishingHouseId",
                table: "ABooks",
                column: "PublishingHouseId",
                principalTable: "PublishingHouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Books_ABooks_BookId",
                table: "Authors_Books",
                column: "BookId",
                principalTable: "ABooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
