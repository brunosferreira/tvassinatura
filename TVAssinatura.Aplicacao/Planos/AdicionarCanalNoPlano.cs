using System;
using TVAssinatura.Dominio.Planos;
using TVAssinatura.Dominio.Planos.Canais;

namespace TVAssinatura.Aplicacao.Planos
{
    public class AdicionarCanalNoPlano
    {
        private IPlanoRepositorio _planoRepositorio;

        public AdicionarCanalNoPlano(IPlanoRepositorio planoRepositorio)
        {
            _planoRepositorio = planoRepositorio;
        }

        public void Adicionar(int idDoPlano, Canal canal)
        {
            if (_planoRepositorio.ExisteCanalNoPlano(idDoPlano, canal.Id))
                throw new ArgumentException("Este canal já pertence a este plano");
            var plano = _planoRepositorio.ObterPorId(idDoPlano);
            plano.AdicionarCanal(canal);
        }
    }
}
