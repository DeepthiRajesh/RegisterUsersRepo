using Microsoft.EntityFrameworkCore;
using RegisteredUsers.DataAccess.Sql.Models;

namespace RegisteredUsers.DataAccess.Sql.Core
{
    public class RepositoryDetailContexts : DbContext
    {
        public RepositoryDetailContexts(DbContextOptions<RepositoryDetailContexts> options) : base(options)
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
                    MiddleName = "Rajesk",
                    LastName = "Kuzhikkattil",
                    Author = "TES International (United States)",
                    ArticleType = "Author",
                    RegistrationDate = "28/04/2020",
                    EditingAssignments = 0,
                    ReviewAssignments = 0,
                    Submission = 1,
                    Place = "Troy, United States",
                    Email = "automationuser081320@vialoopregistration.com",
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
                    BoardInvitationsRemoveFromBoard = 0
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
                    Email = "automationuser081320@vialoopregistration.com",
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
                    BoardInvitationsRemoveFromBoard = 0
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
                    Email = "automationuser081320@vialoopregistration.com",
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
                    BoardInvitationsRemoveFromBoard = 0
                },
                new User
                {
                    Id = 4,
                    FirstName = "Malu",
                    MiddleName = "Kannan",
                    LastName = "",
                    Author = "TES International (United States)",
                    ArticleType = "Author",
                    RegistrationDate = "28/04/2020",
                    EditingAssignments = 0,
                    ReviewAssignments = 0,
                    Submission = 1,
                    Place = "Troy, United States",
                    Email = "automationuser081320@vialoopregistration.com",
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
                    BoardInvitationsRemoveFromBoard = 0
                },
                new User
                {
                    Id = 5,
                    FirstName = "Divya",
                    MiddleName = "Rajesh",
                    LastName = "Kuzhikkattil",
                    Author = "TES International (United States)",
                    ArticleType = "Author",
                    RegistrationDate = "28/04/2020",
                    EditingAssignments = 0,
                    ReviewAssignments = 0,
                    Submission = 1,
                    Place = "Troy, United States",
                    Email = "automationuser081320@vialoopregistration.com",
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
                    BoardInvitationsRemoveFromBoard = 0
                }
            ) ;
        }
    }
}
