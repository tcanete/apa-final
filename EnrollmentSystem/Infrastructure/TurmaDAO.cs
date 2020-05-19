using System.Collections.Generic;

namespace EnrollmentSystem.Infrastructure
{
    public class TurmaDAO
    {
        private SistemaCobol _sistemaCobol;

        public TurmaDAO(SistemaCobol sistemaCobol)
        {
            this._sistemaCobol = sistemaCobol;
        }

        public IList<TurmaCobolDTO> Listar()
        {
            return _sistemaCobol.ListarTurmas();
        }

        public bool Add(TurmaCobolDTO turma)
        {
            return this._sistemaCobol.AddTurma(turma);
        }

        public bool Update(TurmaDomain.Turma turma)
        {
            var turmaCobol = new TurmaCobolDTO
            {
                //mapping aluno
            };

            return this._sistemaCobol.UpdateTurma(turmaCobol);
        }

        public TurmaDomain.Turma GetTurma(Guid id)
        {
            var turma = _sistemaCobol.GetTurma(id);

            return new AlunoDomain.Turma
            {
                //mapping
            };
        }
    }
}