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

        // GET: api/Configuration/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Configuration
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Configuration/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
