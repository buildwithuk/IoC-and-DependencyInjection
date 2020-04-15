using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IoC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Data> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Data
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55)
            })
            .ToArray();
        }
    }
}
