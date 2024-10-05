using System.ComponentModel.DataAnnotations;

namespace Desafio3.Models
{
    public class TareaT
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La descripción de la tarea es obligatoria.")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "La descripción debe tener al menos 5 caracteres.")]
        public string Descripcion { get; set; }
        
        [Required(ErrorMessage = "El proyecto es obligatorio.")]
        public int ProyectoId { get; set; }
        public ProyectoT? Proyecto { get; set; }
        
        [Required(ErrorMessage = "El estado de la tarea es obligatorio.")]        
        [RegularExpression("Pendiente|En Progreso|Completada", ErrorMessage = "El estado debe ser 'Pendiente', 'En Progreso' o 'Completada'.")]
        public string Estado { get; set; }
    }
}
