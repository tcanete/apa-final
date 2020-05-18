using System;
using System.Linq;
using EnrollmentSystem.Infrastructure.Aluno;

namespace EnrollmentSystem.Application.UseCases.Matricula.Listar
{
    public class ListarInteractor : IInteractor<Guid, ListarOutput>
    {
        private AlunoDAO _alunoDAO;

        public ListarInteractor(AlunoDAO alunoDAO)
        {
            this._alunoDAO = alunoDAO;
        }

        public ListarOutput Processar(Guid id)
        {
            var aluno = _alunoDAO.GetAluno(id);
            var output = new ListarOutput
            {
                NomeAluno = aluno.Nome,
                Matricula = aluno.Matricula,
                Disciplinas = aluno.Disciplinas.Select(d => new Domain.Disciplinas.Disciplina
                {
                    Id = d.Id,
                    Nome = d.Nome,
                    MaximoAlunos = d.MaximoAlunos,
                    SemestreOferta = d.SemestreOferta
                })
                .ToList()
            };

            return output;
        }
    }
}