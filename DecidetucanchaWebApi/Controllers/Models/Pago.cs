using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DecidetucanchaWebApi.Controllers.Models
{
    public class Pago
    {
        [Key]
        public int PagoID { get; set; }

        [ForeignKey("Reserva")]
        public int ReservaID { get; set; }
        public Reserva Reserva { get; set; }

        [ForeignKey("MetodoPago")]
        public int MetodoPagoID { get; set; }
        public MetodoPago MetodoPago { get; set; }

        [Required]
        public double Monto { get; set; }

        [Required, MaxLength(15)]
        public string EstadoPago { get; set; } = "Pendiente";

        public DateTime FechaPago { get; set; } = DateTime.Now;
    }
}
