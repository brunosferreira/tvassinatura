using TVAssinatura.Dominio.Clientes;

namespace TVAssinatura.Aplicacao.Clientes
{
    public class ConsultaCliente
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ConsultaCliente(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public Cliente ObterPorCpf(string cpfDoCliente)
        {
            return _clienteRepositorio.ObterPorCpf(cpfDoCliente);
        }

        public Cliente ObterPorId(int id)
        {
            return _clienteRepositorio.ObterPorId(id);
        }
    }
}
