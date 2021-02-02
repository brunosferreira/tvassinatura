using ExpectedObjects;
using System;
using TVAssinatura.Dominio.Clientes;
using TVAssinatura.Dominio.Clientes.Enderecos;
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

            var cliente = new Cliente(clienteEsperado.Cpf, clienteEsperado.Nome, clienteEsperado.DataDeNascimento, clienteEsperado.TelefoneDeContato);

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

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveCriarClienteComTelefoneDeContatoInvalido(string telefoneDeContato)
        {
            Assert.Throws<ArgumentException>(() => ClienteBuilder.Novo().ComTelefoneDeContato(telefoneDeContato).Build());
        }

        [Fact]
        public void DeveAlterarTelefoneDeContato()
        {
            string novoTelefoneDeContato = "67981233038";
            var cliente = ClienteBuilder.Novo().Build();

            cliente.AlterarTelefoneDeContato(novoTelefoneDeContato);

            Assert.Equal(cliente.TelefoneDeContato, novoTelefoneDeContato);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveAlterarTelefoneDeContatoParaInvalido(string novoTelefoneDeContato)
        {
            var cliente = ClienteBuilder.Novo().Build();

            Assert.Throws<ArgumentException>(() => cliente.AlterarTelefoneDeContato(novoTelefoneDeContato));
        }

        [Fact]
        public void DeveClienteAdicionarEndereco()
        {
            var cliente = ClienteBuilder.Novo().Build();
            var enderecoEsperado = EnderecoBuilder.Novo().Build();

            cliente.AdicionarEndereco(enderecoEsperado);

            enderecoEsperado.ToExpectedObject().ShouldEqual(cliente.Endereco);
        }
    }
}
