using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2023.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Transacao> Transacoes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
