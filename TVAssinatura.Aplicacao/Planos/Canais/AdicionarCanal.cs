using System;
using TVAssinatura.Dominio.Planos.Canais;

namespace TVAssinatura.Aplicacao.Planos.Canais
{
    public class AdicionarCanal
    {
        private readonly ICanalRepositorio _canalRepositorio;

        public AdicionarCanal(ICanalRepositorio canalRepositorio)
        {
            _canalRepositorio = canalRepositorio;
        }

        public int Adicionar(Canal canal)
        {
            if (string.IsNullOrWhiteSpace(canal.Nome))
                ValidarNomeCanal(canal.Nome);

            var _canal = new Canal(canal.Numero, canal.Nome, canal.Categoria);
            _canalRepositorio.Adicionar(_canal);

            return _canal.Id;
        }

        public void ValidarNomeCanal(string nome)
        {
            var canal = _canalRepositorio.ObterPorNome(nome);
            if (canal != null)
                throw new Exception("Jà existe um canal com este nome.");
        }

    }
}
