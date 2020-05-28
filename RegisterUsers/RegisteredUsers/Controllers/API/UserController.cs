using Microsoft.AspNetCore.Mvc;
using RegisteredUsers.Domain.Abstract.Service.Entity;
using RegisteredUsers.Presentation.UI.Controllers.API.Helpers;
using RegisteredUsers.Presentation.UI.ViewModel;
using System;
using System.Net;

namespace RegisteredUsers.Presentation.UI.Controllers.API
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }



        [HttpGet]
        public IActionResult GetUserDetails()
        {

            try
            {
                var result = this.userService.GetUserDetails();

                return Ok(result.ToUserDetailViewModel());
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException(ex.Message);
            }
        }


    }
}