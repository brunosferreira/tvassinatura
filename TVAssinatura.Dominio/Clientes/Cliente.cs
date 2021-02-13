using System;
using TVAssinatura.Dominio._Base;
using TVAssinatura.Dominio.Clientes.Enderecos;

namespace TVAssinatura.Dominio.Clientes
{
    public class Cliente : Entidade
    {
        public string Cpf { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public Endereco Endereco { get; private set; }
        public string TelefoneDeContato { get; private set; }

        public Cliente(string cpf, string nome, DateTime dataDeNascimento, string telefoneDeContato)
        {
            Validar(cpf, nome);
            ValidarTelefoneDeContato(telefoneDeContato);
            Cpf = cpf;
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            TelefoneDeContato = telefoneDeContato;
        }

        private void Validar(string cpf, string nome)
        {
            if (string.IsNullOrEmpty(cpf))
                throw new ArgumentException("O Cpf informado é inválido.");

            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("O Nome informado é inválido.");
        }

        private void ValidarTelefoneDeContato(string telefoneDeContato)
        {
            if (string.IsNullOrWhiteSpace(telefoneDeContato))
                throw new ArgumentException("O telefone informado é inválido");
        }

        public void AdicionarEndereco(Endereco endereco)
        {
            if (Endereco != null)
                throw new ArgumentException("Cliente com endereço já cadastrado.");

            Endereco = endereco;
        }

        public void AlterarTelefoneDeContato(string novoTelefoneDeContato)
        {
            ValidarTelefoneDeContato(novoTelefoneDeContato);
            TelefoneDeContato = novoTelefoneDeContato;
        }
    }
}
