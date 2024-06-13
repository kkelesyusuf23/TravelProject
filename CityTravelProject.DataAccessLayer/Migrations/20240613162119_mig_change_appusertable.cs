using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityTravelProject.DataAccessLayer.Migrations
{
    public partial class mig_change_appusertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_AspNetUsers_AppUserId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_AppUserId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Locations");

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Routes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Routes_AppUserID",
                table: "Routes",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_AspNetUsers_AppUserID",
                table: "Routes",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_AspNetUsers_AppUserID",
                table: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Routes_AppUserID",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Routes");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_AppUserId",
                table: "Locations",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_AspNetUsers_AppUserId",
                table: "Locations",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
