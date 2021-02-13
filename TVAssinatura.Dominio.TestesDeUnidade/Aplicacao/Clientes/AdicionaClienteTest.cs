using Moq;
using System;
using TVAssinatura.Aplicacao.Clientes;
using TVAssinatura.Dominio.Clientes;
using TVAssinatura.Dominio.TestesDeUnidade._Builders;
using Xunit;

namespace TVAssinatura.Dominio.TestesDeUnidade.Aplicacao.Clientes
{
    public class AdicionaClienteTest
    {
        private readonly AdicionaCliente _adicionaCliente;
        private readonly Mock<IClienteRepositorio> _clienteRepositorioMock;

        public AdicionaClienteTest()
        {
            _clienteRepositorioMock = new Mock<IClienteRepositorio>();
            _adicionaCliente = new AdicionaCliente(_clienteRepositorioMock.Object);
        }

        [Fact]
        public void DeveAdicionarCliente()
        {
            var cliente = ClienteBuilder.Novo().Build();

            _adicionaCliente.Adicionar(cliente);

            _clienteRepositorioMock.Verify(c => c.Adicionar(It.Is<Cliente>(c =>
                c.Nome == cliente.Nome &&
                c.Cpf == cliente.Cpf
            )));
        }

        [Fact]
        public void NaoDeveAdicionarClienteComCpfJaCadastrado()
        {
            var cliente = ClienteBuilder.Novo().Build();
            var clienteJaSalvo = ClienteBuilder.Novo().ComCpf(cliente.Cpf).Build();
            _clienteRepositorioMock.Setup(c => c.ObterPorCpf(clienteJaSalvo.Cpf)).Returns(clienteJaSalvo);
            Assert.Throws<ArgumentException>(() => _adicionaCliente.Adicionar(cliente));
        }
    }
}
