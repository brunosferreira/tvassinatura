
using TVAssinatura.Dominio._Base;

namespace TVAssinatura.Dominio.Planos
{
    public interface IPlanoRepositorio : IRepositorio<Plano>
    {
        Plano ObterPorNome(string nome);
    }
}
