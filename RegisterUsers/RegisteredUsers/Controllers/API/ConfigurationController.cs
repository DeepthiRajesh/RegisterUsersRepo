using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace RegisteredUsers.Presentation.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly AppSettings appSettings;

        public ConfigurationController(IOptions<AppSettings> option)
        {
            appSettings = option.Value;
        }
        // GET: api/Configuration
        [HttpGet]
        public AppSettings Get()
        {
            return appSettings;
        }
    }
}
