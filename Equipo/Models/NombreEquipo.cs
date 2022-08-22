using System.ComponentModel.DataAnnotations;
namespace Equipo.Models
{
    public class NombreEquipos
    {
       
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [StringLength(maximumLength:15, MinimumLength=6, ErrorMessage ="El nombre debe ser minimo de {2} y máximo de {1} caracteres")]
        public string NombreEquipo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Logo { get; set; }
    
    }
}

