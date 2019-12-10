using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private SettingsWithCollection settings { get; set; }

        public TestController(IConfiguration config)
        {
            settings = config.Get<SettingsWithCollection>();
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return settings.props;
        }
    }
}
