using RegisteredUsers.Domain.Entities.Document;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegisteredUsers.Domain.Abstract.Repository.Document
{
    public interface IUserDocumentRepository
    {
        void Replicate(Domain.Entities.Document.User user);

    }
}
