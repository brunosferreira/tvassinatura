using TVAssinatura.Dominio.Clientes;
using TVAssinatura.Dominio.Clientes.Enderecos;

namespace TVAssinatura.Aplicacao.Clientes
{
    public class AlteraEnderecoCliente
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public AlteraEnderecoCliente(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public void AlterarEndereco(int idDoCliente, Endereco enderecoNovo)
        {
            var cliente = _clienteRepositorio.ObterPorId(idDoCliente);
            var enderecoDoCliente = cliente.Endereco;
            enderecoDoCliente.Alterar(enderecoNovo.Logradouro, enderecoNovo.Numero, enderecoNovo.Cep, enderecoNovo.Cidade, enderecoNovo.Estado);
        }
    }
}
