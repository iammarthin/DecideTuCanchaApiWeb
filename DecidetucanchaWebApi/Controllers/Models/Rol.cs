using System.ComponentModel.DataAnnotations;

namespace DecidetucanchaWebApi.Controllers.Models
{
    public class Rol
    {
        [Key]
        public int RolID { get; set; }

        [Required, MaxLength(50)]
        public string NombreRol { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
