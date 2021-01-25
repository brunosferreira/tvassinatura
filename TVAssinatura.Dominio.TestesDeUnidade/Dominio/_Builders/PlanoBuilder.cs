using Bogus;
using TVAssinatura.Dominio.Planos;

namespace TVAssinatura.Dominio.TestesDeUnidade._Builders
{
    public class PlanoBuilder
    {
        private static Faker faker = new Faker("pt_BR");

        private string Nome = faker.Name.JobTitle();
        private decimal Mensalidade = faker.Finance.Amount(1, 300, 2);

        public static PlanoBuilder Novo()
        {
            return new PlanoBuilder();
        }

        public Plano Build()
        {
            return new Plano(Nome, Mensalidade);
        }

        public PlanoBuilder ComNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public PlanoBuilder ComMensalidade(decimal mensalidade)
        {
            Mensalidade = mensalidade;
            return this;
        }
    }
}
