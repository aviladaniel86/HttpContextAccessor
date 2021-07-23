using HttpContextAccessor.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpContextAccessor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IRequestService _userService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IRequestService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public string Get()
        {
            return _userService.GetRequestPath();
        }
    }
}
