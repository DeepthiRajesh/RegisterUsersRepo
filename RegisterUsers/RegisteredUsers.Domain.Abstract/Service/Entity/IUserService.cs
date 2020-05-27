﻿
using RegisteredUsers.Domain.Entities.Entity;
using System.Collections.Generic;

namespace RegisteredUsers.Domain.Abstract.Service.Entity
{
    public interface IUserService
    {
        IList<User> GetUserDetails();
    } 
}
