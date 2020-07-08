using Hangfire;
using Microsoft.AspNetCore.Mvc;
using RegisteredUsers.Presentation.UI.Controllers.API.Helpers;
using RegisteredUsers.Presentation.ViewModel;
using System;
using System.Collections.Generic;
using System.Net;

namespace RegisteredUsers.Presentation.Controllers.API
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly Domain.Abstract.Service.Entity.IUserService userService;
        private readonly Domain.Abstract.Service.Document.IUserService userDocumentService;

        public UserController(Domain.Abstract.Service.Entity.IUserService userService,
                                Domain.Abstract.Service.Document.IUserService userDocumentService)
        {
            this.userService = userService;
            this.userDocumentService = userDocumentService;
        }


        [HttpGet]
        public IActionResult GetUserDetails()
        {

            try
            {
                var result = this.userService.GetUserDetails();
                foreach (var item in result)
                  {
                   BackgroundJob.Enqueue(() => this.userDocumentService.Replicate(item.ToUserDocumentFromEntity()));
                  }
                    return Ok(result.ToUserDetailViewModel());
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpPost("replicate")]
        public void Replicate()
        {
            try
            {
                var result = this.userService.GetUserDetails();
                foreach (var item in result)
                {
                    BackgroundJob.Enqueue(() => this.userDocumentService.Replicate(item.ToUserDocumentFromEntity()));
                }
            }
            catch (Exception)
            {
                throw;
            }


        }


        [HttpGet("replicate({userId})")]
        public IActionResult GetUserDetailsById([FromRoute] int userId)
        {
            try
            {
                var result = this.userService.GetUserDetailsById(userId); 
                BackgroundJob.Enqueue(() => this.userDocumentService.Replicate(result.ToUserDocumentFromEntity()));
                return Ok(result.ToUserDetailViewModel());
            }
            catch (Exception)
            {
                throw;
            }


        }
       
    }
}