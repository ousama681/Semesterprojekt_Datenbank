using System.Security.RightsManagement;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SemesterprojektDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class addCteFunction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("create Function [dbo].[ArticleGroups]() " +
                                 "returns table " +
                                 "As " +
                                 "return " +
                                 "(" +
                                 "WITH cte_Articlegroup (Id, parentId, Name) AS " +
                                 "(" +
                                 "SELECT ArticleGroup.Id, ArticleGroup.parentId, ArticleGroup.Name " +
                                 "FROM SemesterarbeitDBS.dbo.ArticleGroup " +
                                 "WHERE parentId IS NULL " +
                                 "UNION ALL " +
                                 "SELECT ArticleGroup.Id, ArticleGroup.ParentId, ArticleGroup.Name " +
                                 "FROM SemesterarbeitDBS.dbo.ArticleGroup " +
                                 "INNER JOIN cte_Articlegroup AS cte " +
                                 "ON cte.Id = ArticleGroup.parentId " +
                                 ") " +
                                 "SELECT * FROM cte_Articlegroup);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
