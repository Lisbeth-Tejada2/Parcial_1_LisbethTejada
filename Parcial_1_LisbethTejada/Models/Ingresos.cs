using System.ComponentModel.DataAnnotations;

namespace Parcial_1_LisbethTejada.Models
{
    public class Ingresos
    {
       
            [Key]
            public int IngresoId { get; set; }

            [Required(ErrorMessage = "La fecha requerida es obligatoria. Ejemplo; 02/06/2023")]
            public string Fecha { get; set; }

            [Required(ErrorMessage = "El concepto requerido es obligatorio")]
            public string Concepto { get; set; }

            [Required(ErrorMessage = "El monto requerido es obligatorio. Ejemplo; 5000")]
            public string Monto { get; set; }

    }
}



