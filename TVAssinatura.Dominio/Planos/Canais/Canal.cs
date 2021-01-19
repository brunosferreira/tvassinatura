using System;
using TVAssinatura.Dominio._Base;

namespace TVAssinatura.Dominio.Planos.Canais
{
    public class Canal : Entidade
    {
        public int Numero { get; private set; }
        public string Nome { get; private set; }
        public Categoria Categoria { get; private set; }

        public Canal(int numero, string nome, Categoria categoria)
        {
            if (numero <= 0)
                throw new ArgumentException("O número informado é inválido");
            
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("O nome informado é inválido.");
            
            Numero = numero;
            Nome = nome;
            Categoria = categoria;
        }
    }
}
