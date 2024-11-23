using Microsoft.EntityFrameworkCore;
using DecidetucanchaWebApi.Controllers.Models;

namespace DecidetucanchaWebApi.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        { }
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Complejo> Complejos { get; set; }
        public DbSet<MetodoPago> MetodosPago { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
        public DbSet<Suscripcion> Suscripciones { get; set; }

    }
}
