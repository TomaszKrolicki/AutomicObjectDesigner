using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomicObjectDesignerBack.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DeleteSapJob",
                table: "SapSimple",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ProcessName",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RoutineJob",
                table: "SapSimple",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SapJobName",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SapReport",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SapVariant",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteSapJob",
                table: "SapSimple");

            migrationBuilder.DropColumn(
                name: "ProcessName",
                table: "SapSimple");

            migrationBuilder.DropColumn(
                name: "RoutineJob",
                table: "SapSimple");

            migrationBuilder.DropColumn(
                name: "SapJobName",
                table: "SapSimple");

            migrationBuilder.DropColumn(
                name: "SapReport",
                table: "SapSimple");

            migrationBuilder.DropColumn(
                name: "SapVariant",
                table: "SapSimple");
        }
    }
}
