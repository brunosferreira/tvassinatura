using System.Linq;
using TVAssinatura.Dados.Contextos;
using TVAssinatura.Dominio.Planos;

namespace TVAssinatura.Dados.Repositorios
{
    class PlanoRepositorio : RepositorioBase<Plano>, IPlanoRepositorio
    {
        public PlanoRepositorio(ApplicationDbContext context) : base(context)
        {
        }

        public Plano ObterPorNome(string nome)
        {
            var plano = Context.Set<Plano>().Where(p => p.Nome == nome);
            return plano.Any() ? plano.First() : null;
        }
    }
}
