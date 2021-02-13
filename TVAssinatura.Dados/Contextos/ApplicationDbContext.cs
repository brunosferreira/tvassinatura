using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TVAssinatura.Dominio.Clientes;
using TVAssinatura.Dominio.Clientes.Enderecos;
using TVAssinatura.Dominio.Contratos;
using TVAssinatura.Dominio.Planos;
using TVAssinatura.Dominio.Planos.Canais;

namespace TVAssinatura.Dados.Contextos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Canal> Canais { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public async Task Commit()
        {
            await SaveChangesAsync();
        }
    }
}
