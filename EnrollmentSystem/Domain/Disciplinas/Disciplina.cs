using System;
using System.Collections.Generic;
using System.Linq;
using EnrollmentSystem.Domain.Turmas;

namespace EnrollmentSystem.Domain.Disciplinas
{
    public class Disciplina
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int MaximoAlunos { get; set; }
        public IList<Turma> Turmas { get; set; }
        public DateTime SemestreOferta { get; set; }

        public IList<string> ListarNomeTurmas()
        {
            return this.Turmas.Select(t => t.Nome).ToList();
        }
    }
}