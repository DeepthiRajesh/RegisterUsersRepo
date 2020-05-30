 using RegisteredUsers.Domain.Abstract.Repository.Entity.User;
using RegisteredUsers.Domain.Abstract.Service.Entity;
using RegisteredUsers.Domain.Entities.Entity;
using System.Collections.Generic;

namespace RegisteredUsers.Domain.Service.Entity
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        
        public IList<User> GetUserDetails()
        {
            return this.userRepository.GetUserDetails();  
        }

        public bool IsAuthorise(string email, string password)
        {
            return this.userRepository.IsAuthorise(email, password);
        }
    }
}
