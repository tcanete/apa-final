using EnrollmentSystem.Domain.Disciplinas;
using EnrollmentSystem.Domain.Alunos;

namespace EnrollmentSystem.Domain.Matriculas
{
    public class Matricula
    {
        public Aluno Aluno { get; set; }
        public Disciplina Disciplina { get; set; }

        public bool VerificarAlunoMatriculadoDisciplina() {
            return true;
        }
    }
}