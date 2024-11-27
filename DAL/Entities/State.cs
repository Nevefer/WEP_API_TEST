using System.ComponentModel.DataAnnotations;
using WebAPITest.DAL.Entities;

namespace WEP_API_TEST.DAL.Entities
{
    public class State : AuditBase
    {
        [Display(Name = "Estado / Departamento")] // Identificar Nombre 
        [MaxLength(50, ErrorMessage = "El campo {0} dbe tener maximo {1} caracteres")] //Longitud MAxima
        [Required(ErrorMessage = "El campo {0} es olbigatorio")] // Obligatorio
        public string Name { get; set; }

        //Asi es como relaciono 2 tablas en EF Core
        [Display(Name = "Pais")]
        public Country? Country { get; set; }

        //FK
        [Display(Name = "Id Pais")]
        public Guid CountryId { get; set; }

    }
}
