using System;
using System.Collections.Generic;
using EnrollmentSystem.Domain.Disciplinas;
using EnrollmentSystem.Domain.Turmas;

namespace EnrollmentSystem.Domain.Alunos
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Turma Turma { get; set; }
        public IList<Disciplina> Disciplinas { get; set; }
    }
}