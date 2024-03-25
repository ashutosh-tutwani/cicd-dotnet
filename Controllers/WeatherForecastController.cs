using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("weather")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var appid = Environment.GetEnvironmentVariable("appid");

            return Ok("weather: " + appid);
        }
    }

    [ApiController]
    [Route("basic")]
    public class WController : ControllerBase
    {


        [HttpGet]
        public IActionResult Get()
        {
            var appid = Environment.GetEnvironmentVariable("appid");

            return Ok("basic: " + appid);
        }
    }
}