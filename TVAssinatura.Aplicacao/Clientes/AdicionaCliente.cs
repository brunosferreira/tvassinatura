using System;
using TVAssinatura.Dominio.Clientes;
using TVAssinatura.Dominio.Clientes.Enderecos;

namespace TVAssinatura.Aplicacao.Clientes
{
    public class AdicionaCliente
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public AdicionaCliente(IClienteRepositorio clienteRepositorio)
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

        private void VerificaClientePorCpf(string cpf)
        {
            var cliente = _clienteRepositorio.ObterPorCpf(cpf);
            if (cliente != null)
                throw new Exception("Já existe um cliente cadastrado com este CPF.");
        }
    }
}
