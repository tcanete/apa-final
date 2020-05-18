using System;
using System.Collections.Generic;
using System.Linq;
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


        public bool VerificarDisciplinaJaMatriculada(Disciplina disciplina)
        {
            return this.Disciplinas.Any(d => d.Id == disciplina.Id);
        }

        public IList<Disciplina> ListarDisciplinasMatriculadas()
        {
            return this.Disciplinas;
        }

        public bool PossuiDisciplina(Disciplina disciplina)
        {
            return this.Disciplinas.Any(d => d.Id == disciplina.Id);
        }

        public bool RemoverDisciplina(Disciplina disciplina)
        {
            this.Disciplinas.Remove(disciplina);

            return true;
        }
    }
}