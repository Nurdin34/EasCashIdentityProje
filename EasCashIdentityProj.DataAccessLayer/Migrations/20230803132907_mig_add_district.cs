using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasCashIdentityProje.DataAccessLayer.Migrations
{
    public partial class mig_add_district : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConFirmCode",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConFirmCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "District",
                table: "AspNetUsers");
        }
    }
}
