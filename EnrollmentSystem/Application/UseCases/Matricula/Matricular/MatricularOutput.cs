namespace EnrollmentSystem.UseCases.Matricular
{
    public class MatricularOutput
    {
        public string NomeAluno { get; set; }
        public int Matricula { get; set; }
        public bool Sucesso { get; set; }
        public string MensagemErro { get; set; }
        public string CodigoErro { get; set; }
    }
}