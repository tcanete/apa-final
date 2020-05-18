using System.Collections.Generic;

namespace EnrollmentSystem.WebApi.DTO
{
    public class ListarResponseDTO
    {
        public IList<ItemListarResponse> Matriculas { get; set; }
    }
}