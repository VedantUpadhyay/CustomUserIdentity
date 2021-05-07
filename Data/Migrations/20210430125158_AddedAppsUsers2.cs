using Microsoft.EntityFrameworkCore.Migrations;

namespace UserIdentity.Data.Migrations
{
    public partial class AddedAppsUsers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "NameUSER");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameUSER",
                table: "AspNetUsers",
                newName: "Name");
        }
    }
}
