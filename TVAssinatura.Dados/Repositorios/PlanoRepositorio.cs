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

        public Plano ObterPlanoPorNome(string nome)
        {
            var plano = Context.Set<Plano>().Where(p => p.Nome == nome);
            if (plano.Any())
                return plano.First();

            return null;
        }
    }
}
