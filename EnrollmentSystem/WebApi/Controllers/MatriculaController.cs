using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnrollmentSystem.Application.UseCases.Listar;
using EnrollmentSystem.UseCases.Matricular;
using EnrollmentSystem.WebApi.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EnrollmentSystem.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class MatriculaController : ControllerBase
    {
        private readonly ILogger<MatriculaController> _logger;

        public MatriculaController(ILogger<MatriculaController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IEnumerable<string> Matricular()
        {
            return Summaries;
        }

        [HttpPost]
        public IEnumerable<string> Cancelar()
        {
            return Summaries;
        }

        [HttpGet("/{id}")]
        public ListarResponseDTO Listar(Guid id)
        {
            var interactor = new ListarInteractor();

            var result = interactor.Processar(id);

            return new ListarResponseDTO();
        }
    }
}
