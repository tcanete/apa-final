namespace EnrollmentSystem.UseCases.Matricular
{
    public class MatricularInput
    {
        public Guid AlunoId { get; set; }
        public Guid DisciplinaId { get; set; }
        public Guid TurmaId { get; set; }
    }
}