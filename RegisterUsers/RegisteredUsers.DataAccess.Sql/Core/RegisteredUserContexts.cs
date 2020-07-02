using Microsoft.EntityFrameworkCore;
using RegisteredUsers.DataAccess.Sql.Models;

namespace RegisteredUsers.DataAccess.Sql.Core
{
    public class RegisteredUserContexts : DbContext
    {
        public RegisteredUserContexts(DbContextOptions<RegisteredUserContexts> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Deepthi",
                    MiddleName = "Rajesh",
                    LastName = "Kuzhikkattil",
                    Author = "TES International (United States)",
                    ArticleType = "Author",
                    RegistrationDate = "06/11/2019",
                    EditingAssignments = 0,
                    ReviewAssignments = 0,
                    Submission = 1,
                    Place = "Troy, United States",
                    Email = "deepthir9597@gmail.com",
                    EditingAssignmentsCurrent = 1,
                    EditingAssignmentsCompleted = 1,
                    ReviewAssignmentsCurrent = 1,
                    ReviewAssignmentsEndosed = 1,
                    ReviewAssignmentsRejected = 0,
                    SubmissionInReview = 0,
                    SubmissionInitialValidation = 0,
                    SubmissionAccepted = 0,
                    SubmissionRejected = 0,
                    BoardInvitations = 1,
                    BoardInvitationsPending = 0,
                    BoardInvitationsAccepted = 1,
                    BoardInvitationsDeclined = 0,
                    BoardInvitationsRevoked = 1,
                    BoardInvitationsRemoveFromBoard = 0,
                    Password = "deepthi97"
                },
                new User
                {
                    Id = 2,
                    FirstName = "Sandheep",
                    MiddleName = "",
                    LastName = "Santhosh",
                    Author = "TES International (United States)",
                    ArticleType = "Author",
                    RegistrationDate = "28/04/2020",
                    EditingAssignments = 0,
                    ReviewAssignments = 0,
                    Submission = 1,
                    Place = "Troy, United States",
                    Email = "sandheepsanthosh@gmail.com",
                    EditingAssignmentsCurrent = 0,
                    EditingAssignmentsCompleted = 1,
                    ReviewAssignmentsCurrent = 0,
                    ReviewAssignmentsEndosed = 1,
                    ReviewAssignmentsRejected = 0,
                    SubmissionInReview = 1,
                    SubmissionInitialValidation = 0,
                    SubmissionAccepted = 0,
                    SubmissionRejected = 1,
                    BoardInvitations = 1,
                    BoardInvitationsPending = 0,
                    BoardInvitationsAccepted = 1,
                    BoardInvitationsDeclined = 0,
                    BoardInvitationsRevoked = 1,
                    BoardInvitationsRemoveFromBoard = 0,
                    Password = "sandheep95"
                },
                new User
                {
                    Id = 3,
                    FirstName = "Keerthana",
                    MiddleName = "L",
                    LastName = "Nair",
                    Author = "TES International (United States)",
                    ArticleType = "Review",
                    RegistrationDate = "28/04/2020",
                    EditingAssignments = 0,
                    ReviewAssignments = 0,
                    Submission = 1,
                    Place = "Troy, United States",
                    Email = "keerthana95@gmail.com",
                    EditingAssignmentsCurrent = 0,
                    EditingAssignmentsCompleted = 1,
                    ReviewAssignmentsCurrent = 0,
                    ReviewAssignmentsEndosed = 1,
                    ReviewAssignmentsRejected = 0,
                    SubmissionInReview = 1,
                    SubmissionInitialValidation = 0,
                    SubmissionAccepted = 0,
                    SubmissionRejected = 1,
                    BoardInvitations = 1,
                    BoardInvitationsPending = 0,
                    BoardInvitationsAccepted = 1,
                    BoardInvitationsDeclined = 0,
                    BoardInvitationsRevoked = 1,
                    BoardInvitationsRemoveFromBoard = 0,
                    Password = "keerthana97"
                },
                new User
                {
                    Id = 4,
                    FirstName = "Malu",
                    MiddleName = "Kannan",
                    LastName = "",
                    Author = "TES International (United States)",
                    ArticleType = "Associate Editor",
                    RegistrationDate = "28/04/2010",
                    EditingAssignments = 0,
                    ReviewAssignments = 0,
                    Submission = 1,
                    Place = "Troy, United States",
                    Email = "malukannan95@gmail.com",
                    EditingAssignmentsCurrent = 0,
                    EditingAssignmentsCompleted = 1,
                    ReviewAssignmentsCurrent = 0,
                    ReviewAssignmentsEndosed = 1,
                    ReviewAssignmentsRejected = 0,
                    SubmissionInReview = 1,
                    SubmissionInitialValidation = 0,
                    SubmissionAccepted = 1,
                    SubmissionRejected = 1,
                    BoardInvitations = 0,
                    BoardInvitationsPending = 1,
                    BoardInvitationsAccepted = 1,
                    BoardInvitationsDeclined = 0,
                    BoardInvitationsRevoked = 1,
                    BoardInvitationsRemoveFromBoard = 0,
                    Password = "malu97"
                },
                new User
                {
                    Id = 5,
                    FirstName = "Divya",
                    MiddleName = "Rajesh",
                    LastName = "Kuzhikkattil",
                    Author = "TES International (United States)",
                    ArticleType = "Author",
                    RegistrationDate = "18/09/2018",
                    EditingAssignments = 0,
                    ReviewAssignments = 0,
                    Submission = 1,
                    Place = "Troy, United States",
                    Email = "divyarajesh0397@outlook.com",
                    EditingAssignmentsCurrent = 0,
                    EditingAssignmentsCompleted = 1,
                    ReviewAssignmentsCurrent = 0,
                    ReviewAssignmentsEndosed = 1,
                    ReviewAssignmentsRejected = 0,
                    SubmissionInReview = 1,
                    SubmissionInitialValidation = 0,
                    SubmissionAccepted = 0,
                    SubmissionRejected = 1,
                    BoardInvitations = 0,
                    BoardInvitationsPending = 0,
                    BoardInvitationsAccepted = 0,
                    BoardInvitationsDeclined = 1,
                    BoardInvitationsRevoked = 1,
                    BoardInvitationsRemoveFromBoard = 0,
                    Password = "divya97"
                }
            ) ;
        }
    }
}
