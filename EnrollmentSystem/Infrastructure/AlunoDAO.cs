using System;
using System.Collections.Generic;
using System.Linq;
using AlunoDomain = EnrollmentSystem.Domain.Alunos;

namespace EnrollmentSystem.Infrastructure.Aluno
{
    public class AlunoDAO
    {
        private SistemaCobol _sistemaCobol;

        public AlunoDAO(SistemaCobol sistemaCobol)
        {
            _sistemaCobol = sistemaCobol;
        }

        public IList<AlunoDomain.Aluno> Listar()
        {
            return _sistemaCobol.ListarAlunos().Select(a => new AlunoDomain.Aluno
            {
                //mapping
            }).ToList();
        }

        public AlunoDomain.Aluno GetAluno(Guid id)
        {
            var aluno = _sistemaCobol.GetAluno(id);

            return new AlunoDomain.Aluno
            {
                //mapping
            };
        }

        public bool Update(AlunoDomain.Aluno aluno)
        {
            var alunoCobol = new AlunoCobolDTO
            {
                //mapping aluno
            };

            return this._sistemaCobol.UpdateAluno(alunoCobol);
        }

        public bool Add(AlunoDomain.Aluno aluno)
        {
            var alunoCobol = new AlunoCobolDTO
            {
                //mapping aluno
            };

            return this._sistemaCobol.AddAluno(alunoCobol);
        }
    }
}