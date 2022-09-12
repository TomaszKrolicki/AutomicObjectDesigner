using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomicObjectDesignerBack.Migrations
{
    public partial class SapJobBwChain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Archive1",
                table: "WindowsSimple");

            migrationBuilder.DropColumn(
                name: "Archive2",
                table: "WindowsSimple");

            migrationBuilder.DropColumn(
                name: "InternalAccount",
                table: "WindowsSimple");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "WindowsSimple");

            migrationBuilder.RenameColumn(
                name: "ProcessInfo",
                table: "WindowsSimple",
                newName: "WinServer");

            migrationBuilder.RenameColumn(
                name: "ObjectName",
                table: "WindowsSimple",
                newName: "WinLogin");

            migrationBuilder.RenameColumn(
                name: "Floder",
                table: "WindowsSimple",
                newName: "SapSid");

            migrationBuilder.RenameColumn(
                name: "Docu",
                table: "WindowsSimple",
                newName: "SapClient");

            migrationBuilder.AlterColumn<string>(
                name: "ProcessName",
                table: "WindowsSimple",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "NameSuffix",
                table: "WindowsSimple",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AddColumn<bool>(
                name: "DeleteSapJob",
                table: "WindowsSimple",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RoutineJob",
                table: "WindowsSimple",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DeleteSapJob",
                table: "UnixGeneral",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SapVariant",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SapSid",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SapReport",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SapJobName",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SapClient",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProcessName",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ObjectName",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AlterColumn<string>(
                name: "SapSid",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SapJobName",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SapClient",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProcessName",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Kette",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Folder",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Archive1",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Archive2",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Docu",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InternalAccount",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ObjectName",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SapReport",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SapVariant",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                column: "Password",
                value: "Admin!11");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteSapJob",
                table: "WindowsSimple");

            migrationBuilder.DropColumn(
                name: "RoutineJob",
                table: "WindowsSimple");

            migrationBuilder.DropColumn(
                name: "DeleteSapJob",
                table: "UnixGeneral");

            migrationBuilder.DropColumn(
                name: "ObjectName",
                table: "SapSimple");

            migrationBuilder.DropColumn(
                name: "SapReport1",
                table: "SapSimple");

            migrationBuilder.DropColumn(
                name: "SapVariant1",
                table: "SapSimple");

            migrationBuilder.DropColumn(
                name: "Archive1",
                table: "SapJobBwChain");

            migrationBuilder.DropColumn(
                name: "Archive2",
                table: "SapJobBwChain");

            migrationBuilder.DropColumn(
                name: "Docu",
                table: "SapJobBwChain");

            migrationBuilder.DropColumn(
                name: "InternalAccount",
                table: "SapJobBwChain");

            migrationBuilder.DropColumn(
                name: "ObjectName",
                table: "SapJobBwChain");

            migrationBuilder.DropColumn(
                name: "SapReport",
                table: "SapJobBwChain");

            migrationBuilder.DropColumn(
                name: "SapVariant",
                table: "SapJobBwChain");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "SapJobBwChain");

            migrationBuilder.RenameColumn(
                name: "WinServer",
                table: "WindowsSimple",
                newName: "ProcessInfo");

            migrationBuilder.RenameColumn(
                name: "WinLogin",
                table: "WindowsSimple",
                newName: "ObjectName");

            migrationBuilder.RenameColumn(
                name: "SapSid",
                table: "WindowsSimple",
                newName: "Floder");

            migrationBuilder.RenameColumn(
                name: "SapClient",
                table: "WindowsSimple",
                newName: "Docu");

            migrationBuilder.AlterColumn<string>(
                name: "ProcessName",
                table: "WindowsSimple",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameSuffix",
                table: "WindowsSimple",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Archive1",
                table: "WindowsSimple",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Archive2",
                table: "WindowsSimple",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InternalAccount",
                table: "WindowsSimple",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "WindowsSimple",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "SapVariant",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SapSid",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SapReport",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SapJobName",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SapClient",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProcessName",
                table: "SapSimple",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SapSid",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SapJobName",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SapClient",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProcessName",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Kette",
                table: "SapJobBwChain",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Folder",
                table: "SapJobBwChain",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100,
                column: "Password",
                value: "admin");
        }
    }
}
