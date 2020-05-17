using System.Collections.Generic;
using EnrollmentSystem.Domain.Alunos;
using EnrollmentSystem.Domain.Disciplinas;
using EnrollmentSystem.Domain.Turmas;

namespace EnrollmentSystem.Infrastructure
{
    public class SistemaCobol
    {
        private IList<Aluno> _Alunos;
        private IList<Turma> _Turmas;
        private IList<Disciplina> _Disciplinas;


        public SistemaCobol()
        {
            this._Alunos = new List<Aluno>();
            this._Turmas = new List<Turma>();
            this._Disciplinas = new List<Disciplina>();
        }


        public IList<Aluno> ListarAlunos() {
            return this._Alunos;
        }

        public IList<Turma> ListarTurmas() {
            return this._Turmas;
        }

        public IList<Disciplina> ListarDisciplinas() {
            return this._Disciplinas;
        }
    }
}