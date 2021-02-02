using System.Collections.Generic;
using TVAssinatura.Dominio.Planos.Canais;

namespace TVAssinatura.Aplicacao.Planos.Canais
{
    public class ConsultarCanal
    {
        private readonly ICanalRepositorio _canalRepositorio;

        public ConsultarCanal(ICanalRepositorio canalRepositorio)
        {
            _canalRepositorio = canalRepositorio;
        }

        public List<Canal> ObterTodosOsCanais()
        {
            return _canalRepositorio.Consultar();
        }

        public Canal ObterPorNome(string nome)
        {
            return _canalRepositorio.ObterPorNome(nome);
        }
    }
}
