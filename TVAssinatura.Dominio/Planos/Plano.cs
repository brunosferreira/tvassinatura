using System;
using System.Collections.Generic;
using TVAssinatura.Dominio._Base;
using TVAssinatura.Dominio.Planos.Canais;

namespace TVAssinatura.Dominio.Planos
{
    public class Plano : Entidade
    {
        public string Nome { get; private set; }
        public decimal Mensalidade { get; private set; }
        public List<Canal> Canais { get; private set; }

        public Plano(string nome, decimal mensalidade)
        {
            Validar(nome, mensalidade);

            Nome = nome;
            Mensalidade = mensalidade;
            Canais = new List<Canal>();
        }

        private static void Validar(string nome, decimal mensalidade)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("O nome informado é inválido");

            if (mensalidade <= 0)
                throw new ArgumentException("O valor da mensalidade informada é inválido");
        }

        public void AdicionarCanal(Canal canal)
        {
            if (canal == null)
                throw new ArgumentException("O canal informado é inválido");

            Canais.Add(canal);
        }
    }
}
