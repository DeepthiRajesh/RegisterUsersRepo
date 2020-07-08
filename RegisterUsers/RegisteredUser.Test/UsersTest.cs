using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using RegisteredUsers.Domain.Abstract.Repository.Entity.User;
using RegisteredUsers.Domain.Entities.Entity;
using RegisteredUsers.Domain.Service.Entity;
using System.Collections.Generic;

namespace RegisteredUser.Test
{
    [TestClass]
    public class UsersTest 
    {
        private UserService service;
        private Mock<User> user;
        private Mock<IUserRepository> mock;
        
        [TestInitialize]
        public void UserServicetTest()
        {
            mock = new Mock<IUserRepository>();
            service = new UserService(mock.Object);
            user = new Mock<User>();
        }

        [TestMethod]
        public void LoginUser_WithValidData_ReturnOk_result()
        {
            mock.Setup(x => x.IsAuthorise(It.IsAny<string>(),It.IsAny<string>())).Returns(true); 
            var results = service.IsAuthorise("deepthi9597@gmail.com", "deepthi97");
            Assert.AreEqual(true, results);
        }

    }

}
