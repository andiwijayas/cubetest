using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using server.Models;
using server.Services;

namespace server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureController : ControllerBase
    {
        private readonly ITemperatureAdapter temperatureAdapter;
        private readonly ILogger<TemperatureController> logger;

        public TemperatureController(
            ITemperatureAdapter temperatureAdapter,
            ILogger<TemperatureController> logger
        )
        {
            this.temperatureAdapter = temperatureAdapter;
            this.logger = logger;

        }

        [HttpGet]
        public TemperatureResponse Post([FromBody]TemperatureRequest request)
        {
            return temperatureAdapter.Convert(request);
        }
    }
}
