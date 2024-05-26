using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyManager.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntitiesAfterRemovingSomeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserToCalendars");

            migrationBuilder.DropTable(
                name: "UserToToDoLists");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Tasks",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "UserToCalendars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalendarId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToCalendars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserToCalendars_Calendars_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "Calendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserToCalendars_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserToToDoLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToDoListId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToToDoLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserToToDoLists_ToDoLists_ToDoListId",
                        column: x => x.ToDoListId,
                        principalTable: "ToDoLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserToToDoLists_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserToCalendars_CalendarId",
                table: "UserToCalendars",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_UserToCalendars_UserId",
                table: "UserToCalendars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserToToDoLists_ToDoListId",
                table: "UserToToDoLists",
                column: "ToDoListId");

            migrationBuilder.CreateIndex(
                name: "IX_UserToToDoLists_UserId",
                table: "UserToToDoLists",
                column: "UserId");
        }
    }
}
