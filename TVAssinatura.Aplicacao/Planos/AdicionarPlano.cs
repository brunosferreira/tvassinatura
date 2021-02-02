using System;
using TVAssinatura.Dominio.Planos;
using TVAssinatura.Dominio.Planos.Canais;

namespace TVAssinatura.Aplicacao.Planos
{
    public class AdicionarPlano
    {
        private readonly IPlanoRepositorio _planoRepositorio;

        public AdicionarPlano(IPlanoRepositorio planoRepositorio)
        {
            _planoRepositorio = planoRepositorio;
        }

        public int Adicionar(Plano plano)
        {
            _planoRepositorio.Adicionar(plano);
            return plano.Id;
        }

        public void AdicionarCanal(int idDoPlano, Canal canal)
        {
            if (CanalEstaNoPlano(idDoPlano, canal))
                throw new Exception("Este canal já pertence a este plano");
            var plano = _planoRepositorio.ObterPorId(idDoPlano);
            plano.AdicionarCanal(canal);
        }

        public void RemoverCanal(int idDoPlano, Canal canal)
        {
            if (!CanalEstaNoPlano(idDoPlano, canal))
                throw new Exception("Este canal não pertence a este plano");
            var plano = _planoRepositorio.ObterPorId(idDoPlano);
            plano.RemoverCanal(canal);
        }

        private bool CanalEstaNoPlano(int idDoPlano, Canal canal)
        {
            var plano = _planoRepositorio.ObterPorId(idDoPlano);
            return plano.Canais.Exists(c => c.Id == canal.Id);
        }
    }
}
