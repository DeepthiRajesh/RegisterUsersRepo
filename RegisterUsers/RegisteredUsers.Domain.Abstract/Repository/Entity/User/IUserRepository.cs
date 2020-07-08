using RegisteredUsers.Domain.Entities.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegisteredUsers.Domain.Abstract.Repository.Entity.User
{
    public interface IUserRepository
    {
        IList<Entities.Entity.User> GetUserDetails();
        bool IsAuthorise(string email, string password);
        Entities.Entity.User GetUserDetailsById(int userId);
    }
}
  