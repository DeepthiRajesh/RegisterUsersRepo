using RegisteredUsers.Domain.Abstract.Repository.Document;
using RegisteredUsers.Domain.Abstract.Service.Document;
using RegisteredUsers.Domain.Entities.Document;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegisteredUsers.Domain.Service.Document
{
    public class UserService : IUserService
    {
        private readonly IUserDocumentRepository userRepository;

        public UserService(IUserDocumentRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Replicate(Domain.Entities.Document.User user)
        {
              this.userRepository.Replicate(user);
        }

    }
}
