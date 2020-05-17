using System;
using System.Collections.Generic;
using System.Linq;
using EnrollmentSystem.Domain.Alunos;

namespace EnrollmentSystem.Domain.Turmas
{
    public class Turma
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }        
        public IList<Aluno> Alunos { get; set; }


        public IList<string> ListarNomesAlunos() {
            return this.Alunos.Select(a => a.Nome).ToList();
        }
    }
}