using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadyia.Web.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactID",
                table: "Contact",
                newName: "ContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "Contact",
                newName: "ContactID");
        }
    }
}
