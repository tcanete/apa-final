using System;
using System.Collections.Generic;

namespace EnrollmentSystem.Infrastructure.Aluno
{
    public class AlunoDAO
    {
        private SistemaCobol _sistemaCobol;

        public AlunoDAO(SistemaCobol sistemaCobol)
        {
            _sistemaCobol = sistemaCobol;
        }

        public IList<AlunoCobolDTO> Listar()
        {
            return _sistemaCobol.ListarAlunos();
        }

        public AlunoCobolDTO GetAluno(Guid id){
            return _sistemaCobol.GetAluno(id);
        }

        public bool Add(AlunoCobolDTO aluno)
        {
            return this._sistemaCobol.AddAluno(aluno);
        }
    }
}