using System.ComponentModel.DataAnnotations;

namespace DecidetucanchaWebApi.Controllers.Models
{
    public class Complejo
    {
        [Key]
        public int ComplejoID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, MaxLength(255)]
        public string Direccion { get; set; }

        [MaxLength(15)]
        public string Telefono { get; set; }

        public string Descripcion { get; set; }

        [Required]
        public double PrecioPorHora { get; set; }

        [Required]
        public int Capacidad { get; set; }

        [Required, MaxLength(15)]
        public string Estado { get; set; } = "Disponible";

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
