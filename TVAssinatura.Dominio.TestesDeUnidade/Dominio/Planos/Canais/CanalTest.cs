using TVAssinatura.Dominio.Planos.Canais;
using Xunit;
using ExpectedObjects;
using System;
using TVAssinatura.Dominio.TestesDeUnidade._Builders;

namespace TVAssinatura.Dominio.TestesDeUnidade.Planos.Canais
{
    public class CanalTest
    {
        [Fact]
        public void DeveCriarCanalDeTV()
        {
            var canalEsperado = CanalBuilder.Novo().Build();

            var canal = new Canal(canalEsperado.Numero, canalEsperado.Nome, canalEsperado.Categoria);

            canalEsperado.ToExpectedObject().ShouldMatch(canal);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void NaoDeveCanalCriarComNumeroZeroOuNegativo(int numero)
        {
            Assert.Throws<ArgumentException>(() => new Canal(numero, "Telecine Pipoca", Categoria.Filmes));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void NaoDeveCanalCriarComNomeInvalido(string nome)
        {
            Assert.Throws<ArgumentException>(() => CanalBuilder.Novo().ComNome(nome).Build());
        }
    }
}
