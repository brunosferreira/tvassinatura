using System.Linq;
using TVAssinatura.Dados.Contextos;
using TVAssinatura.Dominio.Planos;

namespace TVAssinatura.Dados.Repositorios
{
    public class PlanoRepositorio : RepositorioBase<Plano>, IPlanoRepositorio
    {
        public PlanoRepositorio(ApplicationDbContext context) : base(context)
        {
        }

        public bool ExisteCanalNoPlano(int idDoPlano, int idDoCanal)
        {
            return Context.Set<Plano>().Where(p => p.Id == idDoPlano &&
                p.Canais.Contains(p.Canais.Where(c => c.Id == idDoCanal).First())).Any();
        }

        public Plano ObterPorNome(string nome)
        {
            var plano = Context.Set<Plano>().Where(p => p.Nome == nome);
            return plano.Any() ? plano.First() : null;
        }
    }
}
