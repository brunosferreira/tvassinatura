using ExpectedObjects;
using System;
using TVAssinatura.Dominio.Clientes.Enderecos;
using TVAssinatura.Dominio.TestesDeUnidade._Builders;
using Xunit;

namespace TVAssinatura.Dominio.TestesDeUnidade.Clientes.Enderecos
{
    public class EnderecoTest
    {
        [Fact]
        public void DeveCriarUmEndereco()
        {
            var enderecoEsperado = EnderecoBuilder.Novo().Build();

            var endereco = new Endereco(enderecoEsperado.Logradouro, enderecoEsperado.Numero, enderecoEsperado.Cep, enderecoEsperado.Cidade, enderecoEsperado.Estado);

            enderecoEsperado.ToExpectedObject().ShouldMatch(endereco);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveCriarUmEnderecoComLogradouroInvalido(string logradouro)
        {
            Assert.Throws<ArgumentException>(() => EnderecoBuilder.Novo().ComLogradouro(logradouro).Build());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void NaoDeveCriarUmEnderecoComNumeroInvalido(int numero)
        {
            Assert.Throws<ArgumentException>(() => EnderecoBuilder.Novo().ComNumero(numero).Build());
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveCriarUmEnderecoComCepInvalido(string cep)
        {
            Assert.Throws<ArgumentException>(() => EnderecoBuilder.Novo().ComCep(cep).Build());
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveCriarUmEnderecoComCidadeInvalida(string cidade)
        {
            Assert.Throws<ArgumentException>(() => EnderecoBuilder.Novo().ComCidade(cidade).Build());
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDeveCriarUmEnderecoComEstadoInvalido(string estado)
        {
            Assert.Throws<ArgumentException>(() => EnderecoBuilder.Novo().ComEstado(estado).Build());
        }

        [Fact]
        public void DeveAlterarEndereco()
        {
            var endereco = EnderecoBuilder.Novo().Build();
            var enderecoEsperado = new
            {
                Logradouro = "Avenida Afonso Pena",
                Numero = 1500,
                Cep = "79990000",
                Cidade = "Campo Grande",
                Estado = "MS"
            };

            endereco.Alterar(enderecoEsperado.Logradouro, enderecoEsperado.Numero, enderecoEsperado.Cep, enderecoEsperado.Cidade, enderecoEsperado.Estado);

            enderecoEsperado.ToExpectedObject().ShouldMatch(endereco);
        }
    }
}
