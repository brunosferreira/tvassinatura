using TVAssinatura.Dominio.Clientes;

namespace TVAssinatura.Aplicacao.Clientes
{
    public class AlteraCliente
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public AlteraCliente(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public void AlterarTelefoneDeContato(int idDoCliente, string telefone)
        {
            var cliente = _clienteRepositorio.ObterPorId(idDoCliente);
            cliente.AlterarTelefoneDeContato(telefone);
        }
    }
}
