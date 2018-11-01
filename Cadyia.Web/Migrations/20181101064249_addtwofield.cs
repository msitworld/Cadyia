using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadyia.Web.Migrations
{
    public partial class addtwofield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Plans",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Plans",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Plans");
        }
    }
}
