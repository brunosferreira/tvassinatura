using System.Linq;
using TVAssinatura.Dados.Contextos;
using TVAssinatura.Dominio.Clientes;

namespace TVAssinatura.Dados.Repositorios
{
    public class ClienteRepositorio : RepositorioBase<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(ApplicationDbContext context) : base(context)
        {
        }

        public Cliente ObterPeloCpf(string cpf)
        {
            var cliente = Context.Set<Cliente>().Where(c => c.Cpf == cpf);
            if (cliente.Any())
                return cliente.First();
            return null;
        }
    }
}
