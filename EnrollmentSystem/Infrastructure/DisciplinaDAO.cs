using System.Collections.Generic;

namespace EnrollmentSystem.Infrastructure.Disciplina
{
    public class DisciplinaDAO
    {
        private SistemaCobol _sistemaCobol;

        public DisciplinaDAO(SistemaCobol sistemaCobol)
        {
            this._sistemaCobol = sistemaCobol;
        }

        public IList<DisciplinaCobolDTO> Listar() {
            return _sistemaCobol.ListarDisciplinas();
        }

        public bool Add(DisciplinaCobolDTO disciplina)
        {
            return this._sistemaCobol.AddDisciplina(disciplina);
        }
    }
}