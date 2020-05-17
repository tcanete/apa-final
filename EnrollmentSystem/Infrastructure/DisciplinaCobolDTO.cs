using System;
using System.Collections.Generic;

namespace EnrollmentSystem.Infrastructure
{
    public class DisciplinaCobolDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public IList<TurmaCobolDTO> Turmas { get; set; }
        public DateTime SemestreOferta { get; set; }
    }
}