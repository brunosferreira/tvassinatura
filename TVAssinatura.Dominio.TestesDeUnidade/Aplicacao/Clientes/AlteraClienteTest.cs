using Bogus;
using Moq;
using System;
using TVAssinatura.Aplicacao.Clientes;
using TVAssinatura.Dominio.Clientes;
using TVAssinatura.Dominio.TestesDeUnidade._Builders;
using Xunit;

namespace TVAssinatura.Dominio.TestesDeUnidade.Aplicacao.Clientes
{
    public class AlteraClienteTest
    {

        public void DeveAlterarTelefoneDoCliente()
        {
            var fake = new Faker();
            string telefoneEsperado = fake.Phone.PhoneNumber();
            var cliente = ClienteBuilder.Novo().Build();
            var clienteRepositorioMock = new Mock<IClienteRepositorio>();
            var adicionaCliente = new AdicionaCliente(clienteRepositorioMock.Object);
            var alteraCliente = new AlteraCliente(clienteRepositorioMock.Object);

            alteraCliente.AlterarTelefoneDeContato(cliente.Id, telefoneEsperado);

            clienteRepositorioMock.Verify(c => c.Adicionar(It.Is<Cliente>(
                    c => c.TelefoneDeContato == telefoneEsperado
            )));
        }
    }
}
