using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnrollmentSystem.Application.UseCases.Matricula.Listar;
using EnrollmentSystem.UseCases.Matricula.Cancelar;
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
        public CancelarResponseDTO Cancelar(CancelarRequestDTO request)
        {
            var interactor = new CancelarMatriculaInteractor(); //DI

            var input = new CancelarMatriculaInput
            {
                //mapping
            };

            var result = interactor.Processar(input);

            return new CancelarResponseDTO(result);
        }

        [HttpGet("/{id}")]
        public ListarResponseDTO Listar(Guid id)
        {
            var interactor = new ListarInteractor(); //DI
            var result = interactor.Processar(id);
            return new ListarResponseDTO(result);
        }
    }
}
