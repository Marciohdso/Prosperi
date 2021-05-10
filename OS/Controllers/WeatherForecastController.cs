using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Application;

namespace OS.Controllers
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
        private readonly IOSService _oSService;

        public WeatherForecastController(IOSService oSService)
        {
            //_logger = logger;
            this._oSService = oSService;
        }

        public IEnumerable<WeatherForecast> GetOs()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("ObterOS")]
        public IEnumerable<WeatherForecast> ObterOS()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("Obter")]
        public async Task<IEnumerable<Os>> Obter()
        {
            var retoro = await _oSService.ObterOSAsync();
            return retoro;
        }

        [HttpPost("CadastrarOs")]
        public async Task<Os> CadastrarOS(Os ordemServico)
        {
            var rng = new Random();
            var retoro = await _oSService.InsereDadosOSAsync(ordemServico);
            return retoro;
        }
    }
}
