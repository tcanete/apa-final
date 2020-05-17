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
    }
}