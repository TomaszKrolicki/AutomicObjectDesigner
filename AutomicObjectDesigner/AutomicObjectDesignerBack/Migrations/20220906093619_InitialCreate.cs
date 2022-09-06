using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomicObjectDesignerBack.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FileTransfers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Folder = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileTransfers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LinuxSimple",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Folder = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    MaxParallelTasks = table.Column<int>(type: "int", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Queue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinuxSimple", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SapJobBwChain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SapClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapSid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kette = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoutineJob = table.Column<bool>(type: "bit", nullable: false),
                    ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapJobName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteSapJob = table.Column<bool>(type: "bit", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Folder = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    MaxParallelTasks = table.Column<int>(type: "int", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Queue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SapJobBwChain", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SapSimple",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SapClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapSid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapReport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapVariant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoutineJob = table.Column<bool>(type: "bit", nullable: true),
                    ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapJobName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteSapJob = table.Column<bool>(type: "bit", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Folder = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    MaxParallelTasks = table.Column<int>(type: "int", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Queue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SapSimple", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SapVariantCopy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Folder = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    MaxParallelTasks = table.Column<int>(type: "int", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Queue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SapVariantCopy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnixGeneral",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnixServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnixLogin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapSid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SapReport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoutineJob = table.Column<bool>(type: "bit", nullable: false),
                    ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameSuffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Folder = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    MaxParallelTasks = table.Column<int>(type: "int", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Queue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnixGeneral", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    HasEmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    IsAdministrator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WindowsSimple",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessName = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    NameSuffix = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ObjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Docu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Archive1 = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Archive2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    InternalAccount = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Floder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Folder = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    MaxParallelTasks = table.Column<int>(type: "int", nullable: true),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Queue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WindowsSimple", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "HasEmailConfirmed", "IsAdministrator", "LastName", "Password", "UserName" },
                values: new object[] { 100, "admin@gmail.com", "Admin", true, true, "Admin", "admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileTransfers");

            migrationBuilder.DropTable(
                name: "LinuxSimple");

            migrationBuilder.DropTable(
                name: "SapJobBwChain");

            migrationBuilder.DropTable(
                name: "SapSimple");

            migrationBuilder.DropTable(
                name: "SapVariantCopy");

            migrationBuilder.DropTable(
                name: "UnixGeneral");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WindowsSimple");
        }
    }
}
