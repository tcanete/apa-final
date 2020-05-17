using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnrollmentSystem.UseCases.Matricular;
using EnrollmentSystem.WebApi.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EnrollmentSystem.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class DisciplinaController : ControllerBase
    {
        private readonly ILogger<MatriculaController> _logger;

        public DisciplinaController(ILogger<MatriculaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Listar()
        {

            var interactor = new MatricularInteractor();
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
