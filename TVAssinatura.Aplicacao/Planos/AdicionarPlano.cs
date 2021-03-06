﻿using System;
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
    }
}
