using ExpectedObjects;
using System;
using TVAssinatura.Dominio.Planos;
using TVAssinatura.Dominio.TestesDeUnidade._Builders;
using Xunit;

namespace TVAssinatura.Dominio.TestesDeUnidade.Planos
{
    public class PlanoTest
    {
        [Fact]
        public void DeveCriarUmPlano()
        {
            var planoEsperado = new
            {
                Nome = "Plano Básico",
                Mensalidade = 99.90M
            };

            var plano = new Plano(planoEsperado.Nome, planoEsperado.Mensalidade);

            planoEsperado.ToExpectedObject().ShouldMatch(plano);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void NaoDevePlanoCriarComNomeInvalido(string nome)
        {
            Assert.Throws<ArgumentException>(() => PlanoBuilder.Novo().ComNome(nome).Build());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void NaoDevePlanoCriarComMensalidadeMenorOuIgualAZero(decimal mensalidade)
        {
            Assert.Throws<ArgumentException>(() => PlanoBuilder.Novo().ComMensalidade(mensalidade).Build());
        }

        [Fact]
        public void NaoDevePlanoAdicionarCanalInvalido()
        {
            var plano = PlanoBuilder.Novo().Build();
            Assert.Throws<ArgumentException>(() => plano.AdicionarCanal(null));
        }
    }
}
