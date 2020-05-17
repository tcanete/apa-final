using System;
using System.Collections.Generic;

namespace EnrollmentSystem.Infrastructure
{
    public class AlunoCobolDTO
    {
        public Guid Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public TurmaCobolDTO Turma { get; set; }
        public IList<DisciplinaCobolDTO> Disciplinas { get; set; }
    }
}