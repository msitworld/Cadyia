using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadyia.Web.Migrations
{
    public partial class identityUserForeignkey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageID",
                table: "Plans",
                newName: "ImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "Plans",
                newName: "ImageID");
        }
    }
}
