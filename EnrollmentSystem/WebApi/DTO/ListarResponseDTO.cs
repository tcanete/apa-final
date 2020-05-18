using System.Collections.Generic;
using System.Linq;
using EnrollmentSystem.Application.UseCases.Matricula.Listar;

namespace EnrollmentSystem.WebApi.DTO
{
    public class ListarResponseDTO
    {
        public string NomeAluno { get; set; }
        public int Matricula { get; set; }
        public IList<ItemListarResponseDTO> Disciplinas { get; set; }

        public ListarResponseDTO(ListarOutput output)
        {
            this.NomeAluno = output.NomeAluno;
            this.Matricula = output.Matricula;
            this.Disciplinas = output.Disciplinas.Select(d => new ItemListarResponseDTO
            {
                NomeDisciplina = d.Nome,
                TurmaDisciplina = d.Turmas.Where(t => t.Id == output.IdTurma).FirstOrDefault().Nome
            }).ToList();
        }
    }
}