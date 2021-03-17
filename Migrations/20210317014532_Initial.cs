using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IS413_Temple_Signup_ZS.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    groupID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    groupName = table.Column<string>(type: "TEXT", nullable: false),
                    groupSize = table.Column<int>(type: "INTEGER", nullable: false),
                    emailAddress = table.Column<string>(type: "TEXT", nullable: false),
                    phoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    tourTime = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.groupID);
                });

            migrationBuilder.CreateTable(
                name: "timeSlots",
                columns: table => new
                {
                    slotID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    scheduleInfo = table.Column<DateTime>(type: "TEXT", nullable: false),
                    availablility = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_timeSlots", x => x.slotID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "timeSlots");
        }
    }
}
