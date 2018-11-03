using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadyia.Web.Migrations
{
    public partial class m7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlanDownload_Plans_PlanId",
                table: "PlanDownload");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanDownload_AspNetUsers_UserId",
                table: "PlanDownload");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanView_Plans_PlanId",
                table: "PlanView");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanView_AspNetUsers_UserId",
                table: "PlanView");

            migrationBuilder.DropForeignKey(
                name: "FK_UserContact_Contact_ContactId",
                table: "UserContact");

            migrationBuilder.DropForeignKey(
                name: "FK_UserContact_AspNetUsers_UserId",
                table: "UserContact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserContact",
                table: "UserContact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanView",
                table: "PlanView");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanDownload",
                table: "PlanDownload");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.RenameTable(
                name: "UserContact",
                newName: "UserContacts");

            migrationBuilder.RenameTable(
                name: "PlanView",
                newName: "PlanViews");

            migrationBuilder.RenameTable(
                name: "PlanDownload",
                newName: "PlanDownloads");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.RenameIndex(
                name: "IX_UserContact_UserId",
                table: "UserContacts",
                newName: "IX_UserContacts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PlanView_UserId",
                table: "PlanViews",
                newName: "IX_PlanViews_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PlanDownload_UserId",
                table: "PlanDownloads",
                newName: "IX_PlanDownloads_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserContacts",
                table: "UserContacts",
                columns: new[] { "ContactId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanViews",
                table: "PlanViews",
                columns: new[] { "PlanId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanDownloads",
                table: "PlanDownloads",
                columns: new[] { "PlanId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "ContactId");

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    LanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageCode = table.Column<string>(nullable: true),
                    LanguageName = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.LanguageID);
                });

            migrationBuilder.CreateTable(
                name: "PlanGlobal",
                columns: table => new
                {
                    PlanId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanGlobal", x => new { x.PlanId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_PlanGlobal_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanGlobal_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "PlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanGlobal_LanguageId",
                table: "PlanGlobal",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlanDownloads_Plans_PlanId",
                table: "PlanDownloads",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "PlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanDownloads_AspNetUsers_UserId",
                table: "PlanDownloads",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanViews_Plans_PlanId",
                table: "PlanViews",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "PlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanViews_AspNetUsers_UserId",
                table: "PlanViews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserContacts_Contacts_ContactId",
                table: "UserContacts",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserContacts_AspNetUsers_UserId",
                table: "UserContacts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlanDownloads_Plans_PlanId",
                table: "PlanDownloads");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanDownloads_AspNetUsers_UserId",
                table: "PlanDownloads");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanViews_Plans_PlanId",
                table: "PlanViews");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanViews_AspNetUsers_UserId",
                table: "PlanViews");

            migrationBuilder.DropForeignKey(
                name: "FK_UserContacts_Contacts_ContactId",
                table: "UserContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_UserContacts_AspNetUsers_UserId",
                table: "UserContacts");

            migrationBuilder.DropTable(
                name: "PlanGlobal");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserContacts",
                table: "UserContacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanViews",
                table: "PlanViews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanDownloads",
                table: "PlanDownloads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.RenameTable(
                name: "UserContacts",
                newName: "UserContact");

            migrationBuilder.RenameTable(
                name: "PlanViews",
                newName: "PlanView");

            migrationBuilder.RenameTable(
                name: "PlanDownloads",
                newName: "PlanDownload");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.RenameIndex(
                name: "IX_UserContacts_UserId",
                table: "UserContact",
                newName: "IX_UserContact_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PlanViews_UserId",
                table: "PlanView",
                newName: "IX_PlanView_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PlanDownloads_UserId",
                table: "PlanDownload",
                newName: "IX_PlanDownload_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserContact",
                table: "UserContact",
                columns: new[] { "ContactId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanView",
                table: "PlanView",
                columns: new[] { "PlanId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanDownload",
                table: "PlanDownload",
                columns: new[] { "PlanId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlanDownload_Plans_PlanId",
                table: "PlanDownload",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "PlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanDownload_AspNetUsers_UserId",
                table: "PlanDownload",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanView_Plans_PlanId",
                table: "PlanView",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "PlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanView_AspNetUsers_UserId",
                table: "PlanView",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserContact_Contact_ContactId",
                table: "UserContact",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserContact_AspNetUsers_UserId",
                table: "UserContact",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
