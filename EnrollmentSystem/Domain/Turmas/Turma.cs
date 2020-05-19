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
        public int MaximoAlunos { get; set; }
        public DateTime Inicio { get; set; }

        public IList<string> ListarNomesAlunos() {
            return this.Alunos.Select(a => a.Nome).ToList();
        }

        public bool PodeMatricular() {
            var ListaAlunos = new IList<string> this.ListarNomesAlunos;
            int AlunosMatriculados = sizeof(ListaAlunos);

            return (DateTime.Now < this.DataInicio) && (AlunosMatriculados < this.MaximoAlunos);
        }

        public bool MatricularDisciplina(Disciplina disciplina)
        {
            this.Disciplinas.Remove(disciplina);

            return true;
        }
    }
}