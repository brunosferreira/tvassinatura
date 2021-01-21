using System.Collections.Generic;

namespace TVAssinatura.Dominio.Planos.Canais
{
    public interface ICanalRepositorio
    {
        Canal ObterCanalPorNome(string nome);
        List<Canal> ObterCanaisPorCategoria(Categoria categoria);
    }
}
