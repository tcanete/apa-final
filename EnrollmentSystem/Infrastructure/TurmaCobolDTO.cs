using System;
using System.Collections.Generic;

namespace EnrollmentSystem.Infrastructure
{
    public class TurmaCobolDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }        
        public IList<AlunoCobolDTO> Alunos { get; set; }
        public int MaximoAlunos { get; set; }
        public DateTime Inicio { get; set; }
    }
}