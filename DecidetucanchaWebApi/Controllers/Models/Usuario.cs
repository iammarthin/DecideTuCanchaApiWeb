using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DecidetucanchaWebApi.Controllers.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string Contraseña { get; set; }

        [MaxLength(15)]
        public string Telefono { get; set; }

        [ForeignKey("Rol")]
        public int RolID { get; set; }
        public Rol Rol { get; set; }

        [Required, MaxLength(10)]
        public string Estado { get; set; } = "Activo";

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
