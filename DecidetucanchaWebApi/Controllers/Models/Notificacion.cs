using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DecidetucanchaWebApi.Controllers.Models
{
    public class Notificacion
    {
        [Key]
        public int NotificacionID { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }

        [Required]
        public string Mensaje { get; set; }

        [Required, MaxLength(15)]
        public string Estado { get; set; } = "Pendiente";

        public DateTime FechaEnvio { get; set; } = DateTime.Now;

        public bool Leida { get; set; } = false;
    }
}
