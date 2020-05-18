using System;
using System.Collections.Generic;
using DisciplinaDomain = EnrollmentSystem.Domain.Disciplinas;

namespace EnrollmentSystem.Infrastructure.Disciplina
{
    public class DisciplinaDAO
    {
        private SistemaCobol _sistemaCobol;

        public DisciplinaDAO(SistemaCobol sistemaCobol)
        {
            this._sistemaCobol = sistemaCobol;
        }

        public IList<DisciplinaCobolDTO> Listar()
        {
            return _sistemaCobol.ListarDisciplinas();
        }

        public DisciplinaDomain.Disciplina GetDisciplina(Guid id)
        {
            var disciplinaCobol = _sistemaCobol.GetDisciplina(id);
            var disciplina = new DisciplinaDomain.Disciplina
            {
                //mapping disciplinaCobol
            };

            return disciplina;
        }
        public bool Add(DisciplinaCobolDTO disciplina)
        {
            return this._sistemaCobol.AddDisciplina(disciplina);
        }
    }
}