using Microsoft.AspNetCore.Mvc;
using RegisteredUsers.Domain.Abstract.Service.Entity;
using RegisteredUsers.Presentation.UI.Controllers.API.Helpers;
using RegisteredUsers.Presentation.UI.ViewModel;
using System;

namespace RegisteredUsers.Presentation.UI.Controllers.API
{
    [Route("api/v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("registration")]
        public IActionResult Registraion([FromBody] UserViewModel model)
        {
            try
            {
                return Ok(this.userService.Registration(model.ToUserDomain()));
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException(ex.Message);
            }
        }
        [HttpPost("login")]
        public IActionResult IsAuthorise([FromBody] UserViewModel model)
        {
            try
            {
                return Ok(this.userService.IsAuthorise( model.Email, model.Password)) ;
            }
            catch(Exception ex)
            {
                throw new ArgumentNullException(ex.Message);
            }
        }
    }
}
