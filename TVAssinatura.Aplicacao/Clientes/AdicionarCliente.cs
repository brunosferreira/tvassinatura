using System;
using System.Collections.Generic;
using System.Text;
using TVAssinatura.Dominio.Clientes;
using TVAssinatura.Dominio.Clientes.Enderecos;

namespace TVAssinatura.Aplicacao.Clientes
{
    public class AdicionarCliente
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public AdicionarCliente(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public int Adicionar(Cliente cliente)
        {
            _clienteRepositorio.Adicionar(cliente);
            return cliente.Id;
        }

        public void AdicionarEndereco(int idDoCliente, Endereco endereco)
        {
            var cliente = _clienteRepositorio.ObterPorId(idDoCliente);
            cliente.AdicionarEndereco(endereco);
        }

        public void AlterarEndereco(int idDoCliente, Endereco enderecoNovo)
        {
            var cliente = _clienteRepositorio.ObterPorId(idDoCliente);
            var enderecoDoCliente = cliente.Endereco;
            enderecoDoCliente.Alterar(enderecoNovo.Logradouro, enderecoNovo.Numero, enderecoNovo.Cep, enderecoNovo.Cidade, enderecoNovo.Estado);
        }

        public void AlterarTelefoneDeContato(int idDoCliente, string telefone)
        {
            var cliente = _clienteRepositorio.ObterPorId(idDoCliente);
            cliente.AlterarTelefoneDeContato(telefone);
        }

    }
}
