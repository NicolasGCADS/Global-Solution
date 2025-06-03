using Microsoft.EntityFrameworkCore;
using SafeZoneModel;

namespace SafeZoneData
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<DispositivoModel> Dispositivos { get; set; }
        public DbSet<LeituraModel> Leituras { get; set; }
        public DbSet<AlertaModel> Alertas { get; set; }

      
    }
}
