using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SemesterprojektDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class databaseFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_ArticleGroup_Id",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Article_MWST_MwstId",
                table: "Article");

            migrationBuilder.RenameColumn(
                name: "MwstId",
                table: "Article",
                newName: "Mwstid");

            migrationBuilder.RenameIndex(
                name: "IX_Article_MwstId",
                table: "Article",
                newName: "IX_Article_Mwstid");

            migrationBuilder.CreateIndex(
                name: "IX_Article_ArticleGroupId",
                table: "Article",
                column: "ArticleGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_ArticleGroup_ArticleGroupId",
                table: "Article",
                column: "ArticleGroupId",
                principalTable: "ArticleGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Article_MWST_Mwstid",
                table: "Article",
                column: "Mwstid",
                principalTable: "MWST",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_ArticleGroup_ArticleGroupId",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Article_MWST_Mwstid",
                table: "Article");

            migrationBuilder.DropIndex(
                name: "IX_Article_ArticleGroupId",
                table: "Article");

            migrationBuilder.RenameColumn(
                name: "Mwstid",
                table: "Article",
                newName: "MwstId");

            migrationBuilder.RenameIndex(
                name: "IX_Article_Mwstid",
                table: "Article",
                newName: "IX_Article_MwstId");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_ArticleGroup_Id",
                table: "Article",
                column: "Id",
                principalTable: "ArticleGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Article_MWST_MwstId",
                table: "Article",
                column: "MwstId",
                principalTable: "MWST",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
