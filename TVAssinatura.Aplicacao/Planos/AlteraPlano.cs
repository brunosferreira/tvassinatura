using System;
using TVAssinatura.Dominio.Planos;
using TVAssinatura.Dominio.Planos.Canais;

namespace TVAssinatura.Aplicacao.Planos
{
    public class AlteraPlano
    {
        private readonly IPlanoRepositorio _planoRepositorio;

        public AlteraPlano(IPlanoRepositorio planoRepositorio)
        {
            _planoRepositorio = planoRepositorio;
        }
    }
}
