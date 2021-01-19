using ExpectedObjects;
using System;
using TVAssinatura.Dominio.Contratos;
using TVAssinatura.Dominio.TestesDeUnidade._Builders;
using Xunit;

namespace TVAssinatura.Dominio.TestesDeUnidade.Contratos
{
    public class ContratoTest
    {
        private static DateTime dataDoContratoMenosUmAno = DateTime.Today.AddYears(-1);
        
        [Fact]
        public void DeveCriarUmContrato()
        {
            var contratoEsperado = new
            {
                Cliente = ClienteBuilder.Novo().Build(),
                Plano = PlanoBuilder.Novo().Build(),
                DataDaAssinatura = DateTime.Today
            };

            var contrato = new Contrato(contratoEsperado.Cliente, contratoEsperado.Plano, contratoEsperado.DataDaAssinatura);

            contratoEsperado.ToExpectedObject().ShouldMatch(contrato);
        }

        [Fact]
        public void NaoDeveCriarContratoComClienteInvalido()
        {
            Assert.Throws<ArgumentException>(() => new Contrato(null, PlanoBuilder.Novo().Build(), DateTime.Today));
        }

        [Fact]
        public void NaoDeveCriarContratoComPlanoInvalido()
        {
            Assert.Throws<ArgumentException>(() => new Contrato(ClienteBuilder.Novo().Build(), null, DateTime.Today));
        }

        [Fact]
        public void NaoDeveCriaContratoComDataInvalida()
        {
            var dataDoContratoInvalida = DateTime.Today.AddDays(1);
            Assert.Throws<ArgumentException>(() => new Contrato(ClienteBuilder.Novo().Build(), PlanoBuilder.Novo().Build(), dataDoContratoInvalida));
        }

        [Theory]
        [InlineData(99.9, 99.9, "2020-10-01")]
        [InlineData(220.0, 198.0, "2019-10-01")]
        public void DeveCalcularOValorDaMensalidade(decimal valorDaMensalidadeOriginal, decimal valorDaMensalidadeEsperado, DateTime dataDaAssinatura)
        {
            var contrato = new Contrato(ClienteBuilder.Novo().Build(), PlanoBuilder.Novo().ComMensalidade(valorDaMensalidadeOriginal).Build(), dataDaAssinatura);

            var valorDaMensalidade = contrato.ObterOValorDaMensalidade();

            Assert.Equal(valorDaMensalidadeEsperado, valorDaMensalidade);
        }
    }
}
