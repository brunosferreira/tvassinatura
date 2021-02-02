
using TVAssinatura.Dominio._Base;

namespace TVAssinatura.Dominio.Clientes
{
    public interface IClienteRepositorio : IRepositorio<Cliente>
    {
        Cliente ObterPorCpf(string cpf);
    }
}
