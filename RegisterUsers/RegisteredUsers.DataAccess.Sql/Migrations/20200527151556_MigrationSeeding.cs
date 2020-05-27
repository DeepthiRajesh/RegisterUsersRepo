using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisteredUsers.DataAccess.Sql.Migrations
{
    public partial class MigrationSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ArticleType", "Author", "BoardInvitations", "BoardInvitationsAccepted", "BoardInvitationsDeclined", "BoardInvitationsPending", "BoardInvitationsRemoveFromBoard", "BoardInvitationsRevoked", "EditingAssignments", "EditingAssignmentsCompleted", "EditingAssignmentsCurrent", "Email", "FirstName", "LastName", "MiddleName", "Place", "RegistrationDate", "ReviewAssignments", "ReviewAssignmentsCurrent", "ReviewAssignmentsEndosed", "ReviewAssignmentsRejected", "Submission", "SubmissionAccepted", "SubmissionInReview", "SubmissionInitialValidation", "SubmissionRejected" },
                values: new object[,]
                {
                    { 2, "Author", "TES International (United States)", 1, 1, 0, 0, 0, 1, 0, 1, 0, "automationuser081320@vialoopregistration.com", "Sandheep", "Santhosh", "", "Troy, United States", "28/04/2020", 0, 0, 1, 0, 1, 0, 1, 0, 1 },
                    { 3, "Review", "TES International (United States)", 1, 1, 0, 0, 0, 1, 0, 1, 0, "automationuser081320@vialoopregistration.com", "Keerthana", "Nair", "L", "Troy, United States", "28/04/2020", 0, 0, 1, 0, 1, 0, 1, 0, 1 },
                    { 4, "Author", "TES International (United States)", 1, 1, 0, 0, 0, 1, 0, 1, 0, "automationuser081320@vialoopregistration.com", "Malu", "", "Kannan", "Troy, United States", "28/04/2020", 0, 0, 1, 0, 1, 0, 1, 0, 1 },
                    { 5, "Author", "TES International (United States)", 1, 1, 0, 0, 0, 1, 0, 1, 0, "automationuser081320@vialoopregistration.com", "Divya", "Kuzhikkattil", "Rajesh", "Troy, United States", "28/04/2020", 0, 0, 1, 0, 1, 0, 1, 0, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
