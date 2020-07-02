using RegisteredUsers.DataAccess.Mongo.Mdo;
using RegisteredUsers.DataAccess.Mongo.Mdo.User;
using RegisteredUsers.Domain.Entities.Document;
using RegisteredUsers.Infrastructure.Common.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace RegisteredUsers.DataAccess.Mongo.Helpers
{
    public static class UserDocumentRepositoryHelper
    {
        public static Users ToUserDocument(this User documentMdo)
        {
            return documentMdo != null ? new Users 
            {

                Id = documentMdo.Id,
                FirstName = documentMdo.FirstName,
                MiddleName = documentMdo.MiddleName,
                LastName = documentMdo.LastName,
                Author = documentMdo.Author,
                ArticleType = documentMdo.ArticleType,
                RegistrationDate = documentMdo.RegistrationDate,
                EditingAssignments = documentMdo.EditingAssignments,
                ReviewAssignments = documentMdo.ReviewAssignments,
                Submission = documentMdo.Submission,
                Place = documentMdo.Place,
                Email = documentMdo.Email,
                EditingAssignmentsCurrent = documentMdo.EditingAssignmentsCurrent,
                EditingAssignmentsCompleted = documentMdo.EditingAssignmentsCompleted,
                ReviewAssignmentsCurrent = documentMdo.ReviewAssignmentsCurrent,
                ReviewAssignmentsEndosed = documentMdo.ReviewAssignmentsEndosed,
                ReviewAssignmentsRejected = documentMdo.ReviewAssignmentsRejected,
                SubmissionInReview = documentMdo.SubmissionInReview,
                SubmissionInitialValidation = documentMdo.SubmissionInitialValidation,
                SubmissionAccepted = documentMdo.SubmissionAccepted,
                SubmissionRejected = documentMdo.SubmissionRejected,
                BoardInvitations = documentMdo.BoardInvitations,
                BoardInvitationsPending = documentMdo.BoardInvitationsPending,
                BoardInvitationsAccepted = documentMdo.BoardInvitationsAccepted,
                BoardInvitationsDeclined = documentMdo.BoardInvitationsDeclined,
                BoardInvitationsRevoked = documentMdo.BoardInvitationsRevoked,
                BoardInvitationsRemoveFromBoard = documentMdo.BoardInvitationsRemoveFromBoard,


            } : null;
        }
        public static IList<Users> ToUserDocument(this IList<User> user)
        {
            return user.Select(x => ToUserDocument(x)).ToList();

        }
    }
}
