using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegisteredUsers.Presentation.UI.ViewModel
{
    public class UserViewModel 
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


    }
}
