using RegisteredUsers.Domain.Entities.Entity;
using RegisteredUsers.Presentation.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace RegisteredUsers.Presentation.UI.Controllers.API.Helpers
{
    public static class UserControllerHelpers
    {
        public static UserViewModel ToUserDetailViewModel(this User userModel)
        {
            return userModel != null ? new UserViewModel
            {
                Id = userModel.Id,
                FirstName = userModel.FirstName,
                MiddleName = userModel.MiddleName,
                LastName = userModel.LastName,
                Author = userModel.Author,
                ArticleType = userModel.ArticleType,
                RegistrationDate = userModel.RegistrationDate,
                EditingAssignments =userModel.EditingAssignments,
                ReviewAssignments = userModel.ReviewAssignments,
                Submission = userModel.Submission,
                Place = userModel.Place,
                Email = userModel.Email,
                EditingAssignmentsCurrent = userModel.EditingAssignmentsCurrent,
                EditingAssignmentsCompleted = userModel.EditingAssignmentsCompleted,
                ReviewAssignmentsCurrent = userModel.ReviewAssignmentsCurrent,
                ReviewAssignmentsEndosed = userModel.ReviewAssignmentsEndosed,
                ReviewAssignmentsRejected = userModel.ReviewAssignmentsRejected,
                SubmissionInReview = userModel.SubmissionInReview,
                SubmissionInitialValidation = userModel.SubmissionInitialValidation,
                SubmissionAccepted = userModel.SubmissionAccepted,
                SubmissionRejected = userModel.SubmissionRejected,
                BoardInvitations= userModel.BoardInvitations,
                BoardInvitationsPending = userModel.BoardInvitationsPending,
                BoardInvitationsAccepted = userModel.BoardInvitationsAccepted,
                BoardInvitationsDeclined = userModel.BoardInvitationsDeclined,
                BoardInvitationsRevoked = userModel.BoardInvitationsRevoked,
                BoardInvitationsRemoveFromBoard = userModel.BoardInvitationsRemoveFromBoard,
            } : null;

        }
        public static IList<UserViewModel> ToUserDetailViewModel(this IList<User> user)
        {
            return user.Select(x => ToUserDetailViewModel(x)).ToList();
        }
        public static Domain.Entities.Document.User ToUserDocumentFromEntity(this Domain.Entities.Entity.User userModel)
        { 
            return userModel != null ? new Domain.Entities.Document.User
            {
                Id = userModel.Id,
                FirstName = userModel.FirstName,
                MiddleName = userModel.MiddleName,
                LastName = userModel.LastName,
                Author = userModel.Author,
                ArticleType = userModel.ArticleType,
                RegistrationDate = userModel.RegistrationDate,
                EditingAssignments = userModel.EditingAssignments,
                ReviewAssignments = userModel.ReviewAssignments,
                Submission = userModel.Submission,
                Place = userModel.Place,
                Email = userModel.Email,
                EditingAssignmentsCurrent = userModel.EditingAssignmentsCurrent,
                EditingAssignmentsCompleted = userModel.EditingAssignmentsCompleted,
                ReviewAssignmentsCurrent = userModel.ReviewAssignmentsCurrent,
                ReviewAssignmentsEndosed = userModel.ReviewAssignmentsEndosed,
                ReviewAssignmentsRejected = userModel.ReviewAssignmentsRejected, 
                SubmissionInReview = userModel.SubmissionInReview,
                SubmissionInitialValidation = userModel.SubmissionInitialValidation,
                SubmissionAccepted = userModel.SubmissionAccepted,
                SubmissionRejected = userModel.SubmissionRejected,
                BoardInvitations = userModel.BoardInvitations,
                BoardInvitationsPending = userModel.BoardInvitationsPending,
                BoardInvitationsAccepted = userModel.BoardInvitationsAccepted,
                BoardInvitationsDeclined = userModel.BoardInvitationsDeclined,
                BoardInvitationsRevoked = userModel.BoardInvitationsRevoked,
                BoardInvitationsRemoveFromBoard = userModel.BoardInvitationsRemoveFromBoard,
            } : null;
        }
    }
}
 