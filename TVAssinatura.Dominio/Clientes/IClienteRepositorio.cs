using TVAssinatura.Dominio._Base;

namespace TVAssinatura.Dominio.Clientes
{
    public interface IClienteRepositorio
    {
        Cliente ObterPeloCpf(string cpf);
    }
}
