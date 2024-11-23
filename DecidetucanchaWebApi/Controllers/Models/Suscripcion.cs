using System.ComponentModel.DataAnnotations;

namespace DecidetucanchaWebApi.Controllers.Models
{
    public class Suscripcion
    {
        [Key]
        public int SuscripcionID { get; set; } // Clave primaria

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; } // Dirección de correo electrónico

        [Required, MaxLength(15)]
        public string Estado { get; set; } = "Activa"; // Activa o Cancelada

        public DateTime FechaRegistro { get; set; } = DateTime.Now; // Fecha de registro de la suscripción
    }
}
