using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TwoHundrendEleven.TadaaApp.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lists",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lastupdated = table.Column<long>(nullable: false),
                    status = table.Column<bool>(nullable: false),
                    userId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    CreatedDateAndTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 5, 17, 13, 3, 57, 779, DateTimeKind.Local).AddTicks(4204))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lists", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lastupdated = table.Column<long>(nullable: false),
                    status = table.Column<bool>(nullable: false, defaultValue: true),
                    CreatedDateAndTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lastupdated = table.Column<long>(nullable: false),
                    status = table.Column<bool>(nullable: false, defaultValue: true),
                    listId = table.Column<int>(nullable: false),
                    CreatedDateAndTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    TaskExplanation = table.Column<string>(nullable: true),
                    TaskDateAndTime = table.Column<DateTime>(nullable: false),
                    isCompleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CompletedDateAndTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lists");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
