using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisteredUsers.DataAccess.Sql.Migrations
{
    public partial class SeedNewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EditingAssignmentsCurrent", "Email", "MiddleName", "Password", "RegistrationDate", "ReviewAssignmentsCurrent", "SubmissionInReview", "SubmissionRejected" },
                values: new object[] { 1, "deepthir9597@gmail.com", "Rajesh", "deepthi97", "06/11/2019", 1, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Password" },
                values: new object[] { "sandheepsanthosh@gmail.com", "sandheep95" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Password" },
                values: new object[] { "keerthana95@gmail.com", "keerthana97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArticleType", "BoardInvitations", "BoardInvitationsPending", "Email", "Password", "RegistrationDate", "SubmissionAccepted" },
                values: new object[] { "Associate Editor", 0, 1, "malukannan95@gmail.com", "malu97", "28/04/2010", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BoardInvitations", "BoardInvitationsAccepted", "BoardInvitationsDeclined", "Email", "Password", "RegistrationDate" },
                values: new object[] { 0, 0, 1, "divyarajesh0397@outlook.com", "divya97", "18/09/2018" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EditingAssignmentsCurrent", "Email", "MiddleName", "RegistrationDate", "ReviewAssignmentsCurrent", "SubmissionInReview", "SubmissionRejected" },
                values: new object[] { 0, "automationuser081320@vialoopregistration.com", "Rajesk", "28/04/2020", 0, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "automationuser081320@vialoopregistration.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: "automationuser081320@vialoopregistration.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArticleType", "BoardInvitations", "BoardInvitationsPending", "Email", "RegistrationDate", "SubmissionAccepted" },
                values: new object[] { "Author", 1, 0, "automationuser081320@vialoopregistration.com", "28/04/2020", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BoardInvitations", "BoardInvitationsAccepted", "BoardInvitationsDeclined", "Email", "RegistrationDate" },
                values: new object[] { 1, 1, 0, "automationuser081320@vialoopregistration.com", "28/04/2020" });
        }
    }
}
