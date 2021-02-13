
using TVAssinatura.Dominio._Base;

namespace TVAssinatura.Dominio.Planos
{
    public interface IPlanoRepositorio : IRepositorio<Plano>
    {
        Plano ObterPorNome(string nome);
        bool ExisteCanalNoPlano(int idDoPlano, int idDoCanal);
    }
}
