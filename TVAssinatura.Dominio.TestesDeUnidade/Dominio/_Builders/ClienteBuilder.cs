using Bogus;
using System;
using TVAssinatura.Dominio.Clientes;
using TVAssinatura.Dominio.Clientes.Enderecos;

namespace TVAssinatura.Dominio.TestesDeUnidade._Builders
{
    public class ClienteBuilder
    {
        const string cpfInvalido = "12345678901";
        private static Faker faker = new Faker("pt_BR");

        private string Nome = faker.Person.FullName;
        private string Cpf = cpfInvalido;
        private DateTime DataDeNascimento = faker.Person.DateOfBirth;
        private string TelefoneDeContato = faker.Phone.PhoneNumber("#########");

        public static ClienteBuilder Novo()
        {
            return new ClienteBuilder();
        }

        public Cliente Build()
        {
            return new Cliente(Cpf, Nome, DataDeNascimento, TelefoneDeContato);
        }

        public ClienteBuilder ComNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ClienteBuilder ComCpf(string cpf)
        {
            Cpf = cpf;
            return this;
        }

        public ClienteBuilder ComTelefoneDeContato(string telefone)
        {
            TelefoneDeContato = telefone;
            return this;
        }
    }
}
