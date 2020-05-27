using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisteredUsers.DataAccess.Sql.Migrations
{
    public partial class migrationRepo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    ArticleType = table.Column<string>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    EditingAssignments = table.Column<int>(nullable: false),
                    ReviewAssignments = table.Column<int>(nullable: false),
                    Submission = table.Column<int>(nullable: false),
                    Place = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EditingAssignmentsCurrent = table.Column<int>(nullable: false),
                    EditingAssignmentsCompleted = table.Column<int>(nullable: false),
                    ReviewAssignmentsCurrent = table.Column<int>(nullable: false),
                    ReviewAssignmentsEndosed = table.Column<int>(nullable: false),
                    ReviewAssignmentsRejected = table.Column<int>(nullable: false),
                    SubmissionInReview = table.Column<int>(nullable: false),
                    SubmissionInitialValidation = table.Column<int>(nullable: false),
                    SubmissionAccepted = table.Column<int>(nullable: false),
                    SubmissionRejected = table.Column<int>(nullable: false),
                    BoardInvitations = table.Column<int>(nullable: false),
                    BoardInvitationsPending = table.Column<int>(nullable: false),
                    BoardInvitationsAccepted = table.Column<int>(nullable: false),
                    BoardInvitationsDeclined = table.Column<int>(nullable: false),
                    BoardInvitationsRevoked = table.Column<int>(nullable: false),
                    BoardInvitationsRemoveFromBoard = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
