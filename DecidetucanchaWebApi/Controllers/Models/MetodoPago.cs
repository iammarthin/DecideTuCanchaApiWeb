using System.ComponentModel.DataAnnotations;

namespace DecidetucanchaWebApi.Controllers.Models
{
    public class MetodoPago
    {
        [Key]
        public int MetodoPagoID { get; set; }

        [Required, MaxLength(50)]
        public string NombreMetodo { get; set; }

        [Required, MaxLength(10)]
        public string Estado { get; set; } = "Activo";

        public ICollection<Pago> Pagos { get; set; }
    }
}
