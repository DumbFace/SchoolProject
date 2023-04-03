using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Data.Migrations
{
    public partial class FieldThumb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Thumb",
                table: "tblArticle",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Thumb",
                table: "tblArticle");
        }
    }
}
