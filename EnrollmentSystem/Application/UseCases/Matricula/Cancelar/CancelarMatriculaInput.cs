using System;

namespace EnrollmentSystem.UseCases.Matricula.Cancelar
{
    public class CancelarMatriculaInput
    {
        public Guid AlunoId { get; set; }
        public Guid DisciplinaId { get; set; }
        
    }
}