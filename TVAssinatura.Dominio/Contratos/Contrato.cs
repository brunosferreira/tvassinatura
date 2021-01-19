using System;
using TVAssinatura.Dominio._Base;
using TVAssinatura.Dominio.Clientes;
using TVAssinatura.Dominio.Planos;

namespace TVAssinatura.Dominio.Contratos
{
    public class Contrato : Entidade
    {
        private const decimal PercentualDeDescontoVip = 0.1M;
        public Cliente Cliente { get; private set; }
        public Plano Plano { get; private set; }
        public DateTime DataDaAssinatura { get; private set; }
        public bool EhVip => Plano.Mensalidade >= 150.0M && DateTime.Today >= DataDaAssinatura.AddYears(1);

        public Contrato(Cliente cliente, Plano plano, DateTime dataDaAssinatura)
        {
            Validar(cliente, plano, dataDaAssinatura);

            Cliente = cliente;
            Plano = plano;
            DataDaAssinatura = dataDaAssinatura;
        }

        private void Validar(Cliente cliente, Plano plano, DateTime dataDaAssinatura)
        {
            if (cliente == null)
                throw new ArgumentException("O cliente informado é inválido");

            if (plano == null)
                throw new ArgumentException("O plano informado é inválido");

            if (dataDaAssinatura > DateTime.Today)
                throw new ArgumentException("A data informada é inválida");
        }

        public decimal ObterOValorDaMensalidade()
        {
            return Plano.Mensalidade - CalculaDesconto();
        }

        private decimal CalculaDesconto()
        {
            return EhVip ? Plano.Mensalidade * PercentualDeDescontoVip : 0;
        }
    }
}
