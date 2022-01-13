using Microsoft.EntityFrameworkCore.Migrations;

namespace BBFReferee.Infrastructure.Migrations
{
    public partial class connectionRefReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "RefereeTeams");

            migrationBuilder.AddColumn<int>(
                name: "RefereeId",
                table: "Reports",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_RefereeId",
                table: "Reports",
                column: "RefereeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_RefereeTeams_RefereeId",
                table: "Reports",
                column: "RefereeId",
                principalTable: "RefereeTeams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_RefereeTeams_RefereeId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_RefereeId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "RefereeId",
                table: "Reports");

            migrationBuilder.AddColumn<int>(
                name: "ReportId",
                table: "RefereeTeams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
