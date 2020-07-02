using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegisteredUsers.Domain.Abstract.Service.Entity;
using RegisteredUsers.Presentation.ViewModel;

namespace RegisteredUsers.Presentation.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService userService;
        public LoginController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpPost]
        public IActionResult IsAuthorise([FromBody] UserViewModel userModel)
        {
            try
            {
            var result = this.userService.IsAuthorise(userModel.Email, userModel.Password);
            return Ok(result);
            }
            catch(Exception)
            {
                throw;
            }
        }
        
    }


}