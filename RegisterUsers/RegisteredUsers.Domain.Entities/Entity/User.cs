using System;

namespace RegisteredUsers.Domain.Entities.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Author { get; set; }
        public string ArticleType { get; set; }
        public string RegistrationDate { get; set; }
        public int EditingAssignments { get; set; }
        public int ReviewAssignments { get; set; }
        public int Submission { get; set; }
        public string Place { get; set; }
        public string Email { get; set; }
        public int EditingAssignmentsCurrent { get; set; }
        public int EditingAssignmentsCompleted { get; set; }
        public int ReviewAssignmentsCurrent { get; set; }
        public int ReviewAssignmentsEndosed { get; set; }
        public int ReviewAssignmentsRejected { get; set; }
        public int SubmissionInReview { get; set; }
        public int SubmissionInitialValidation { get; set; }
        public int SubmissionAccepted { get; set; }
        public int SubmissionRejected { get; set; }
        public int BoardInvitations { get; set; }
        public int BoardInvitationsPending { get; set; }
        public int BoardInvitationsAccepted { get; set; }
        public int BoardInvitationsDeclined { get; set; }
        public int BoardInvitationsRevoked { get; set; }
        public int BoardInvitationsRemoveFromBoard { get; set; }
        public string Password { get; set; }
        public object Content { get; set; }
    }
}
 