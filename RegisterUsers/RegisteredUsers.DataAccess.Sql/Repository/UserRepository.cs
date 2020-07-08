using RegisteredUsers.DataAccess.Sql.Mapper.User;
using RegisteredUsers.Domain.Abstract.Repository.Entity.User;
using RegisteredUsers.Domain.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisteredUsers.DataAccess.Sql.Core
{
    public class UserRepository : IUserRepository
    {
         private readonly RegisteredUserContexts userDbContext;

        public UserRepository(RegisteredUserContexts userDbContext)
        {
            this.userDbContext = userDbContext;
        }     
        public IList<User> GetUserDetails()
        {
            var user = this.userDbContext.Users.ToList();
          
            return UserMapper.ToDomain(user);
        }
         
        public User GetUserDetailsById(int userId)
        {
                var user = this.userDbContext.Users.FirstOrDefault(x => x.Id == userId);
               
                return UserMapper.ToDomain(user);
           
        }

        public bool IsAuthorise(string email, string password)
        {
            var result = this.userDbContext.Users.Any(x => x.Email == email && x.Password == password);
            return result;
        }
    }
}
