
namespace TVAssinatura.Dominio.Clientes
{
    public interface IClienteRepositorio
    {
        Cliente ObterPeloCpf(string cpf);
    }
}
