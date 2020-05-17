using System;
using System.Collections.Generic;
using EnrollmentSystem.Domain.Turmas;

namespace EnrollmentSystem.Domain.Disciplinas
{
    public class Disciplina
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public IList<Turma> Turmas { get; set; }        
    }
}