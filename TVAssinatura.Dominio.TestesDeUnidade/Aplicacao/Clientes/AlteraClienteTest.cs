using Bogus;
using System;
using TVAssinatura.Aplicacao.Clientes;
using TVAssinatura.Dominio.Clientes;
using TVAssinatura.Dominio.TestesDeUnidade._Builders;
using Xunit;

namespace TVAssinatura.Dominio.TestesDeUnidade.Aplicacao.Clientes
{
    public class AlteraClienteTest : IDisposable
    {
        private IClienteRepositorio _clienteRepositorio;
        private AlteraCliente _alteraCliente;
        private Faker faker;

        public AlteraClienteTest(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
            _alteraCliente = new AlteraCliente(_clienteRepositorio);
            faker = new Faker();
        }

        public void Dispose()
        {
        }

        [Fact]
        public void DeveAlterarTelefoneDoCliente()
        {
            string telefoneDeContatoEsperado = faker.Phone.PhoneNumber();
            Cliente cliente = ClienteBuilder.Novo().Build();

            _alteraCliente.AlterarTelefoneDeContato(cliente.Id, telefoneDeContatoEsperado);

            Assert.Equal(telefoneDeContatoEsperado, cliente.TelefoneDeContato);
        }
    }
}
