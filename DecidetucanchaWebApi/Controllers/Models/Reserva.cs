using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DecidetucanchaWebApi.Controllers.Models
{
    public class Reserva
    {
        [Key]
        public int ReservaID { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }

        [ForeignKey("Complejo")]
        public int ComplejoID { get; set; }
        public Complejo Complejo { get; set; }

        [Required]
        public DateTime FechaReserva { get; set; }

        [Required]
        public TimeSpan HoraInicio { get; set; }

        [Required]
        public TimeSpan HoraFin { get; set; }

        [Required, MaxLength(15)]
        public string Estado { get; set; } = "Pendiente";

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public ICollection<Pago> Pagos { get; set; }
    }
}
