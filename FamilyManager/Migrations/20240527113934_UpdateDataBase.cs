using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyManager.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SharedCalendars");

            migrationBuilder.CreateTable(
                name: "CalendarToFamilies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalendarId = table.Column<int>(type: "int", nullable: false),
                    FamilyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarToFamilies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalendarToFamilies_Calendars_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "Calendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalendarToFamilies_Families_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Families",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalendarToUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalendarId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarToUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalendarToUsers_Calendars_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "Calendars",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CalendarToUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserToFamilies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FamilyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToFamilies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserToFamilies_Families_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Families",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserToFamilies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserToToDoLists_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalendarToFamilies_CalendarId",
                table: "CalendarToFamilies",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarToFamilies_FamilyId",
                table: "CalendarToFamilies",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarToUsers_CalendarId",
                table: "CalendarToUsers",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarToUsers_UserId",
                table: "CalendarToUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserToFamilies_FamilyId",
                table: "UserToFamilies",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserToFamilies_UserId",
                table: "UserToFamilies",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalendarToFamilies");

            migrationBuilder.DropTable(
                name: "CalendarToUsers");

            migrationBuilder.DropTable(
                name: "UserToFamilies");

            migrationBuilder.DropTable(
                name: "UserToToDoLists");

            migrationBuilder.CreateTable(
                name: "SharedCalendars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalendarId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharedCalendars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SharedCalendars_Calendars_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "Calendars",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SharedCalendars_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SharedCalendars_CalendarId",
                table: "SharedCalendars",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_SharedCalendars_UserId",
                table: "SharedCalendars",
                column: "UserId");
        }
    }
}
