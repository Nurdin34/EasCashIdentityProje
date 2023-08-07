using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasCashIdentityProje.DataAccessLayer.Migrations
{
    public partial class mig_add_confirm_code : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ConFirmCode",
                table: "AspNetUsers",
                newName: "ConfirmCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ConfirmCode",
                table: "AspNetUsers",
                newName: "ConFirmCode");
        }
    }
}
