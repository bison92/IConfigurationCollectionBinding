using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        public IOptions<SettingsWithCollection> Options { get; }

        public TestController(IOptions<SettingsWithCollection> options)
        {
            
            Options = options;
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Options.Value.props;
        }
    }
}
