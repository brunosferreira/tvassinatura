using System.Collections.Generic;
using System.Linq;
using TVAssinatura.Dados.Contextos;
using TVAssinatura.Dominio.Planos.Canais;

namespace TVAssinatura.Dados.Repositorios
{
    class CanalRepositorio : RepositorioBase<Canal>, ICanalRepositorio
    {
        public CanalRepositorio(ApplicationDbContext context) : base(context)
        {
        }

        public Canal ObterCanalPorNome(string nome)
        {
            var canal = Context.Set<Canal>().Where(c => c.Nome == nome);
            if (canal.Any())
                return canal.First();
            return null;
        }

        public List<Canal> ObterCanaisPorCategoria(Categoria categoria)
        {
            var canais = Context.Set<Canal>().Where(c => c.Categoria == categoria);
            if (canais.Any())
                return canais.ToList();
            return null;
        }
    }
}
