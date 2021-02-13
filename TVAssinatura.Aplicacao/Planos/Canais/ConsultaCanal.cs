using System.Collections.Generic;
using TVAssinatura.Dominio.Planos.Canais;

namespace TVAssinatura.Aplicacao.Planos.Canais
{
    public class ConsultaCanal
    {
        private readonly ICanalRepositorio _canalRepositorio;

        public ConsultaCanal(ICanalRepositorio canalRepositorio)
        {
            _canalRepositorio = canalRepositorio;
        }

        public List<Canal> ObterTodosOsCanais()
        {
            return _canalRepositorio.ObterTodos();
        }

        public Canal ObterPorNome(string nome)
        {
            return _canalRepositorio.ObterPorNome(nome);
        }
    }
}
