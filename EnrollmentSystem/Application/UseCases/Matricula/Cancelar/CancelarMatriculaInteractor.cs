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
            var retorno = new CancelarMatriculaOutput();
            var aluno = _alunoDAO.GetAluno(input.AlunoId);
            var disciplina = _disciplinaDAO.GetDisciplina(input.DisciplinaId);

            if (aluno.PossuiDisciplina(disciplina) && disciplina.PodeSerCancelada())
            {
                aluno.RemoverDisciplina(disciplina);
                _alunoDAO.Update(aluno);
                retorno.Sucesso = true;
            }
            else
            {
                retorno.Sucesso = false;
                retorno.CodigoErro = "ABC123";
                retorno.MensagemErro = "Matrícula não pode ser cancelada após início";
            }

            return retorno;
        }
    }
}