using System;
using System.Collections.Generic;
using EnrollmentSystem.Domain.Disciplinas;

namespace EnrollmentSystem.Application.UseCases.Matricula.Listar
{
    public class ListarOutput
    {
        public string NomeAluno { get; set; }
        public int Matricula { get; set; }
        public Guid IdTurma { get; set; }
        public IList<Disciplina> Disciplinas { get; set; }
    }
}