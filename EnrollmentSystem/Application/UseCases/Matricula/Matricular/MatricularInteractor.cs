namespace EnrollmentSystem.UseCases.Matricular
{
    public class MatricularInteractor : IInteractor<MatricularInput, MatricularOutput>
    {
        private AlunoDAO _alunoDAO;
        private DisciplinaDAO _disciplinaDAO;
        private TurmaDAO _turmaDAO;

        public MatricularInteractor(AlunoDAO alunoDAO, DisciplinaDAO disciplinaDAO, TurmaDAO turmaDAO)
        {
            this._alunoDAO = alunoDAO;
            this._disciplinaDAO = disciplinaDAO;
            this._turmaDAO = turmaDAO;
        }

        public MatricularOutput Processar(MatricularInput input)
        {            
            var retorno = new MatricularOutput();
            var aluno = _alunoDAO.GetAluno(input.AlunoId);
            var disciplina = _disciplinaDAO.GetDisciplina(input.DisciplinaId);
            var turma = _turmaDAO.GetTurma(input.TurmaId);

            if (turma.PodeMatricular())
            {
                _alunoDAO.Update(aluno);
                _turmaDAO.Update(turma);
                retorno.Sucesso = true;
            }
            else
            {
                retorno.Sucesso = false;
                retorno.CodigoErro = "ABC123";
                retorno.MensagemErro = "Ocorreu um erro durante a matrícula.";
            }

            return retorno;
        }
    }
}