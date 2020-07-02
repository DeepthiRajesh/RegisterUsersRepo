using RegisteredUsers.Domain.Entities.Document;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegisteredUsers.Domain.Abstract.Service.Document
{
    public interface IUserService
    {
        void Replicate(Domain.Entities.Document.User user);

    }
}
