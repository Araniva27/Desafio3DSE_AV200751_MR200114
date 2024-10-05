using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace Desafio3.Models
{
    public class ProyectoT
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del proyecto es obligatorio.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es obligatoria.")]
        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }
        
        [Required(ErrorMessage = "El equipo es obligatorio.")]
        public int EquipoId { get; set; }
        public EquipoT? Equipo { get; set; }
        
        public List<TareaT>? Tareas { get; set; }
    }
}
