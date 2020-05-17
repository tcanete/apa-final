using System.Collections.Generic;

namespace EnrollmentSystem.Infrastructure
{
    public class SistemaCobol
    {
        private IList<AlunoCobolDTO> _Alunos;
        private IList<TurmaCobolDTO> _Turmas;
        private IList<DisciplinaCobolDTO> _Disciplinas;

        public SistemaCobol()
        {
            this._Alunos = new List<AlunoCobolDTO>();
            this._Turmas = new List<TurmaCobolDTO>();
            this._Disciplinas = new List<DisciplinaCobolDTO>();
        }

        public IList<AlunoCobolDTO> ListarAlunos()
        {
            return this._Alunos;
        }

        public bool AddAluno(AlunoCobolDTO aluno)
        {
            this._Alunos.Add(aluno);
            return true;
        }

        public IList<TurmaCobolDTO> ListarTurmas()
        {
            return this._Turmas;
        }

        public bool AddTurma(TurmaCobolDTO turma)
        {
            this._Turmas.Add(turma);
            return true;
        }

        public IList<DisciplinaCobolDTO> ListarDisciplinas()
        {
            return this._Disciplinas;
        }

        public bool AddDisciplina(DisciplinaCobolDTO disciplina)
        {
            this._Disciplinas.Add(disciplina);
            return true;
        }
    }
}