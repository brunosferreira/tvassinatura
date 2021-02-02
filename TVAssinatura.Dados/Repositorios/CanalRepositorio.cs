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

        public Canal ObterPorNome(string nome)
        {
            var canal = Context.Set<Canal>().Where(c => c.Nome == nome);
            return canal.Any() ? canal.First() : null;
        }

        public List<Canal> ObterPorCategoria(Categoria categoria)
        {
            var canais = Context.Set<Canal>().Where(c => c.Categoria == categoria);
            return canais.Any() ? canais.ToList() : null;
        }
    }
}
