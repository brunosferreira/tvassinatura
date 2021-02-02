using System;
using TVAssinatura.Dominio._Base;

namespace TVAssinatura.Dominio.Clientes.Enderecos
{
    public class Endereco : Entidade
    {
        public string Logradouro { get; private set; }
        public int Numero { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

        public Endereco(string logradouro, int numero, string cep, string cidade, string estado)
        {
            Validar(logradouro, numero, cep, cidade, estado);            
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
        }

        private void Validar(string logradouro, int numero, string cep, string cidade, string estado)
        {
            if (string.IsNullOrEmpty(logradouro))
                throw new ArgumentException("O Logradouro informado é inválido");

            if (numero <= 0)
                throw new ArgumentException("O Número informado é inválido");

            if (string.IsNullOrEmpty(cep))
                throw new ArgumentException("O Cep informado é inválido.");

            if (string.IsNullOrEmpty(cidade))
                throw new ArgumentException("A Cidade informado é inválido.");

            if (string.IsNullOrEmpty(estado))
                throw new ArgumentException("O Estado informado é inválido.");
        }

        public void Alterar(string logradouro, int numero, string cep, string cidade, string estado)
        {
            Validar(logradouro, numero, cep, cidade, estado);
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
