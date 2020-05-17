using System;
using System.Collections.Generic;

namespace EnrollmentSystem.Domain.Turmas
{
    public class Turma
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        
        public IList<Aluno> Alunos { get; set; }
    }
}