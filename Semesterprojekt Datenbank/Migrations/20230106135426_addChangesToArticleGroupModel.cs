using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SemesterprojektDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class addChangesToArticleGroupModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "ArticleGroup");

            migrationBuilder.AddColumn<string>(
                name: "ParentName",
                table: "ArticleGroup",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentName",
                table: "ArticleGroup");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "ArticleGroup",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
