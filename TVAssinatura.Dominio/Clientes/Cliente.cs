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

        public Cliente(string cpf, string nome, DateTime dataDeNascimento, Endereco endereco, string telefoneDeContato)
        {
            Validar(cpf, nome);
            Cpf = cpf;
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Endereco = endereco;
            TelefoneDeContato = telefoneDeContato;
        }

        private void Validar(string cpf, string nome)
        {
            if (string.IsNullOrEmpty(cpf))
                throw new ArgumentException("O Cpf informado é inválido.");

            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("O Nome informado é inválido.");
        }
    }
}
