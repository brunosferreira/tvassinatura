using Bogus;
using TVAssinatura.Dominio.Clientes.Enderecos;

namespace TVAssinatura.Dominio.TestesDeUnidade._Builders
{
    public class EnderecoBuilder
    {
        private static Faker faker = new Faker("pt_BR");

        private string Logradouro = faker.Address.StreetName();
        private int Numero = faker.Random.Number(0, 1000);
        private string Cep = faker.Address.ZipCode("########");
        private string Cidade = faker.Address.City();
        private string Estado = faker.Address.StateAbbr();
        public static EnderecoBuilder Novo()
        {
            return new EnderecoBuilder();
        }

        public Endereco Build()
        {
            return new Endereco(Logradouro, Numero, Cep, Cidade, Estado);
        }

        public EnderecoBuilder ComLogradouro(string logradouro)
        {
            Logradouro = logradouro;
            return this;
        }

        public EnderecoBuilder ComNumero(int numero)
        {
            Numero = numero;
            return this;
        }

        public EnderecoBuilder ComCep(string cep)
        {
            Cep = cep;
            return this;
        }

        public EnderecoBuilder ComCidade(string cidade)
        {
            Cidade = cidade;
            return this;
        }

        public EnderecoBuilder ComEstado(string estado)
        {
            Estado = estado;
            return this;
        }
    }
}
