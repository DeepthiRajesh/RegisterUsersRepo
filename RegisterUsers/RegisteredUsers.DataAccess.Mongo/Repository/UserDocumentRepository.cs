using Microsoft.Extensions.Options;
using MongoDB.Driver;
using RegisteredUsers.DataAccess.Mongo.Core;
using RegisteredUsers.DataAccess.Mongo.Helpers;
using RegisteredUsers.DataAccess.Mongo.Mdo.User;
using RegisteredUsers.Domain.Abstract.Repository.Document;
using RegisteredUsers.Domain.Entities.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisteredUsers.DataAccess.Mongo.Repository
{
    public class UserDocumentRepository : MongoRepository, IUserDocumentRepository
    { 
        public UserDocumentRepository(IOptions<Settings> configSettings) :
       base(configSettings)
        {
             

        }

        public async void Replicate(User user)
        {
            try
            {
                var datas = user.ToUserDocument();


                var filter = Builders<Users>.Filter.Where(x => x.Id == user.Id);

                var update = Builders<Users>.Update
                            .Set(s => s.FirstName, user.FirstName)
                            .Set(s => s.MiddleName, user.MiddleName)
                            .Set(s => s.LastName, user.LastName)
                            .Set(s => s.Author, user.Author)
                            .Set(s => s.ArticleType, user.ArticleType)
                            .Set(s => s.RegistrationDate, user.RegistrationDate)
                            .Set(s => s.EditingAssignments, user.EditingAssignments)
                            .Set(s => s.ReviewAssignments, user.ReviewAssignments)
                            .Set(s => s.Submission, user.Submission)
                            .Set(s => s.Place, user.Place)
                            .Set(s => s.Email, user.Email)
                            .Set(s => s.EditingAssignmentsCurrent, user.EditingAssignmentsCurrent)
                            .Set(s => s.EditingAssignmentsCompleted, user.EditingAssignmentsCompleted)
                            .Set(s => s.ReviewAssignmentsCurrent, user.ReviewAssignmentsCurrent)
                            .Set(s => s.ReviewAssignmentsEndosed, user.ReviewAssignmentsEndosed)
                            .Set(s => s.ReviewAssignmentsRejected, user.ReviewAssignmentsRejected)
                            .Set(s => s.SubmissionInReview, user.SubmissionInReview)
                            .Set(s => s.SubmissionInitialValidation, user.SubmissionInitialValidation)
                            .Set(s => s.SubmissionAccepted, user.SubmissionAccepted)
                            .Set(s => s.SubmissionRejected, user.SubmissionRejected)
                            .Set(s => s.BoardInvitations, user.BoardInvitations)
                            .Set(s => s.BoardInvitationsPending, user.BoardInvitationsPending)
                            .Set(s => s.BoardInvitationsAccepted, user.BoardInvitationsAccepted)
                            .Set(s => s.BoardInvitationsDeclined, user.BoardInvitationsDeclined)
                            .Set(s => s.BoardInvitationsRevoked, user.BoardInvitationsRevoked)
                            .Set(s => s.BoardInvitationsRemoveFromBoard, user.BoardInvitationsRemoveFromBoard)
                            .Set(s => s.Password, user.Password);

                await this.UserDocumentCollection.UpdateOneAsync(filter, update, new UpdateOptions { IsUpsert = true });
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

    }
}
