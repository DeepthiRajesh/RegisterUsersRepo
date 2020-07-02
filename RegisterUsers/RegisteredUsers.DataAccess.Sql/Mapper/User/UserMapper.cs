using RegisteredUsers.Infrastructure.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using static RegisteredUsers.Infrastructure.Common.Enums.EnumTypes;

namespace RegisteredUsers.DataAccess.Sql.Mapper.User
{
    public static class UserMapper
    {
        public static Domain.Entities.Entity.User ToDomain(this Models.User user)
        {
            return new Domain.Entities.Entity.User
            {

                Id = user.Id,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                Author = user.Author,
                ArticleType = user.ArticleType,
                RegistrationDate = user.RegistrationDate,
                EditingAssignments = user.EditingAssignments,
                ReviewAssignments = user.ReviewAssignments,
                Submission = user.Submission,
                Place = user.Place,
                Email = user.Email,
                EditingAssignmentsCurrent = user.EditingAssignmentsCurrent,
                EditingAssignmentsCompleted = user.EditingAssignmentsCompleted,
                ReviewAssignmentsCurrent = user.ReviewAssignmentsCurrent,
                ReviewAssignmentsEndosed = user.ReviewAssignmentsEndosed,
                ReviewAssignmentsRejected = user.ReviewAssignmentsRejected,
                SubmissionInReview = user.SubmissionInReview,
                SubmissionInitialValidation = user.SubmissionInitialValidation,
                SubmissionAccepted = user.SubmissionAccepted,
                SubmissionRejected = user.SubmissionRejected,
                BoardInvitations = user.BoardInvitations,
                BoardInvitationsPending = user.BoardInvitationsPending,
                BoardInvitationsAccepted = user.BoardInvitationsAccepted,
                BoardInvitationsDeclined = user.BoardInvitationsDeclined,
                BoardInvitationsRevoked = user.BoardInvitationsRevoked,
                BoardInvitationsRemoveFromBoard = user.BoardInvitationsRemoveFromBoard
                

            };
        }

        public static IList<Domain.Entities.Entity.User> ToDomain( this IList<Models.User> user)
        {
            return user.Select(x => ToDomain(x)).ToList();

        }
    }
}
