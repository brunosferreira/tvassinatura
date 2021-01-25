using Bogus;
using TVAssinatura.Dominio.Planos.Canais;

namespace TVAssinatura.Dominio.TestesDeUnidade._Builders
{
    public class CanalBuilder
    {
        private static Faker faker = new Faker("pt_BR");

        private int Numero = faker.Random.Number(100, 399);
        private string Nome = faker.Name.JobType();
        private Categoria Categoria = faker.PickRandom<Categoria>();

        public static CanalBuilder Novo()
        {
            return new CanalBuilder();
        }

        public CanalBuilder ComNumero(int numero)
        {
            Numero = numero;
            return this;
        }

        public CanalBuilder ComNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public CanalBuilder ComCategoria(Categoria categoria)
        {
            Categoria = categoria;
            return this;
        }

        public Canal Build()
        {
            return new Canal(Numero, Nome, Categoria);
        }

    }
}
