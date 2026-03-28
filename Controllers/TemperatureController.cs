using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Netcore3TestApp.Models;

namespace Netcore3TestApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Temperature> Get()
        {
            var temperatures = new List<Temperature>
            {
                new Temperature
                {
                    Location = "New York",
                    TemperatureC = 22,
                    Description = "Mild"
                },
                new Temperature
                {
                    Location = "London",
                    TemperatureC = 15,
                    Description = "Cool"
                },
                new Temperature
                {
                    Location = "Tokyo",
                    TemperatureC = 25,
                    Description = "Warm"
                },
                new Temperature
                {
                    Location = "Sydney",
                    TemperatureC = 28,
                    Description = "Hot"
                },
                new Temperature
                {
                    Location = "Dubai",
                    TemperatureC = 38,
                    Description = "Scorching"
                }
            };

            return temperatures;
        }
    }
}
