using ExpectedObjects;
using System;
using TVAssinatura.Dominio.Clientes;
using TVAssinatura.Dominio.TestesDeUnidade._Builders;
using Xunit;

namespace TVAssinatura.Dominio.TestesDeUnidade.Clientes
{
    public class ClienteTest
    {
        [Fact]
        public void DeveCriarUmCliente()
        {
            var clienteEsperado = ClienteBuilder.Novo().Build();

            var cliente = new Cliente(clienteEsperado.Cpf, clienteEsperado.Nome, clienteEsperado.DataDeNascimento, clienteEsperado.Endereco, clienteEsperado.TelefoneDeContato);

            clienteEsperado.ToExpectedObject().ShouldMatch(cliente);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveCriarClienteComCpfInvalido(string cpf)
        {
            Assert.Throws<ArgumentException>(() => ClienteBuilder.Novo().ComCpf(cpf).Build());
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveCriarClienteComNomeInvalido(string nome)
        {
            Assert.Throws<ArgumentException>(() => ClienteBuilder.Novo().ComNome(nome).Build());
        }
    }
}
