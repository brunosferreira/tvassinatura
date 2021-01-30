using System;
using System.Collections.Generic;
using System.Text;
using TVAssinatura.Dominio.Planos.Canais;

namespace TVAssinatura.Aplicacao.Planos.Canais
{
    public class ConsultaDeCanais
    {
        private readonly ICanalRepositorio canalRepositorio;

        public ConsultaDeCanais(ICanalRepositorio _canalRepositorio)
        {
            canalRepositorio = _canalRepositorio;
        }

        public List<Canal> ObterTodosOsCanais()
        {
            return canalRepositorio.Consultar();
        }

        public Canal ObterCanalPorNome(string nome)
        {
            return canalRepositorio.ObterCanalPorNome(nome);
        }
    }
}
