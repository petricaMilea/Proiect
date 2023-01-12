using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect.Migrations
{
    public partial class CorrectAgencyID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Holiday_Agency_AgencyID",
                table: "Holiday");

            migrationBuilder.AlterColumn<int>(
                name: "AgencyID",
                table: "Holiday",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Holiday_Agency_AgencyID",
                table: "Holiday",
                column: "AgencyID",
                principalTable: "Agency",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Holiday_Agency_AgencyID",
                table: "Holiday");

            migrationBuilder.AlterColumn<int>(
                name: "AgencyID",
                table: "Holiday",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Holiday_Agency_AgencyID",
                table: "Holiday",
                column: "AgencyID",
                principalTable: "Agency",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
