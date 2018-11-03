using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadyia.Web.Migrations
{
    public partial class m5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FieldStudyID",
                table: "UserProfiles",
                newName: "FieldStudyId");

            migrationBuilder.RenameColumn(
                name: "AcademicDegreeID",
                table: "UserProfiles",
                newName: "AcademicDegreeId");

            migrationBuilder.RenameColumn(
                name: "AliasName",
                table: "UserProfiles",
                newName: "LocalAliasName");

            migrationBuilder.AlterColumn<int>(
                name: "ProfileView",
                table: "UserProfiles",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnAliasName",
                table: "UserProfiles",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VerifyCode",
                table: "UserContact",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnAliasName",
                table: "UserProfiles");

            migrationBuilder.RenameColumn(
                name: "FieldStudyId",
                table: "UserProfiles",
                newName: "FieldStudyID");

            migrationBuilder.RenameColumn(
                name: "AcademicDegreeId",
                table: "UserProfiles",
                newName: "AcademicDegreeID");

            migrationBuilder.RenameColumn(
                name: "LocalAliasName",
                table: "UserProfiles",
                newName: "AliasName");

            migrationBuilder.AlterColumn<int>(
                name: "ProfileView",
                table: "UserProfiles",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "VerifyCode",
                table: "UserContact",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
