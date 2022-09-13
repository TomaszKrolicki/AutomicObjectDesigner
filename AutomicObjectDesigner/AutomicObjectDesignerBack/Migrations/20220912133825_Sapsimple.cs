using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomicObjectDesignerBack.Migrations
{
    public partial class Sapsimple : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SapReport1",
                table: "SapSimple");

            migrationBuilder.DropColumn(
                name: "SapVariant1",
                table: "SapSimple");

            migrationBuilder.AddColumn<string>(
                name: "Archive1",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Archive2",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InternalAccount1",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title1",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Archive1",
                table: "SapSimple");

            migrationBuilder.DropColumn(
                name: "Archive2",
                table: "SapSimple");

            migrationBuilder.DropColumn(
                name: "InternalAccount1",
                table: "SapSimple");

            migrationBuilder.DropColumn(
                name: "Title1",
                table: "SapSimple");

            migrationBuilder.AddColumn<string>(
                name: "SapReport1",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SapVariant1",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
