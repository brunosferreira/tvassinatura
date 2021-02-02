using System.Collections.Generic;
using TVAssinatura.Dominio._Base;

namespace TVAssinatura.Dominio.Planos.Canais
{
    public interface ICanalRepositorio : IRepositorio<Canal>
    {
        Canal ObterPorNome(string nome);
        List<Canal> ObterPorCategoria(Categoria categoria);
    }
}
