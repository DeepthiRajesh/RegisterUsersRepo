using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisteredUsers.DataAccess.Sql.Migrations
{
    public partial class SeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RegistrationDate",
                table: "Users",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ArticleType", "Author", "BoardInvitations", "BoardInvitationsAccepted", "BoardInvitationsDeclined", "BoardInvitationsPending", "BoardInvitationsRemoveFromBoard", "BoardInvitationsRevoked", "EditingAssignments", "EditingAssignmentsCompleted", "EditingAssignmentsCurrent", "Email", "FirstName", "LastName", "MiddleName", "Place", "RegistrationDate", "ReviewAssignments", "ReviewAssignmentsCurrent", "ReviewAssignmentsEndosed", "ReviewAssignmentsRejected", "Submission", "SubmissionAccepted", "SubmissionInReview", "SubmissionInitialValidation", "SubmissionRejected" },
                values: new object[] { 1, "Author", "TES International (United States)", 1, 1, 0, 0, 0, 1, 0, 1, 0, "automationuser081320@vialoopregistration.com", "Deepthi", "Kuzhikkattil", "Rajesk", "Troy, United States", "28/04/2020", 0, 0, 1, 0, 1, 0, 1, 0, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
