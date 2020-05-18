using EnrollmentSystem.Infrastructure.Aluno;
using EnrollmentSystem.Infrastructure.Disciplina;

namespace EnrollmentSystem.UseCases.Matricula.Cancelar
{
    public class CancelarMatriculaInteractor : IInteractor<CancelarMatriculaInput, CancelarMatriculaOutput>
    {
        private AlunoDAO _alunoDAO;
        private DisciplinaDAO _disciplinaDAO;

        public CancelarMatriculaInteractor(AlunoDAO alunoDAO, DisciplinaDAO disciplinaDAO)
        {
            this._alunoDAO = alunoDAO;
            this._disciplinaDAO = disciplinaDAO;
        }

        public CancelarMatriculaOutput Processar(CancelarMatriculaInput input)
        {
            var aluno = _alunoDAO.GetAluno(input.AlunoId);
            var disciplinaDAO = _disciplinaDAO.GetDisciplina(input.DisciplinaId);


            var retorno = new CancelarMatriculaOutput();
            return retorno;
        }
    }
}