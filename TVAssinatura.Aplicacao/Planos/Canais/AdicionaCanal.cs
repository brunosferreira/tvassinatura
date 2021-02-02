using System;
using TVAssinatura.Dominio.Planos.Canais;

namespace TVAssinatura.Aplicacao.Planos.Canais
{
    public class AdicionaCanal
    {
        private readonly ICanalRepositorio _canalRepositorio;

        public AdicionaCanal(ICanalRepositorio canalRepositorio)
        {
            _canalRepositorio = canalRepositorio;
        }

        public int Adicionar(Canal canal)
        {
            if (string.IsNullOrWhiteSpace(canal.Nome))
                ValidarNomeCanal(canal.Nome);

            _canalRepositorio.Adicionar(canal);

            return canal.Id;
        }

        public void ValidarNomeCanal(string nome)
        {
            var canal = _canalRepositorio.ObterPorNome(nome);
            if (canal != null)
                throw new Exception("Jà existe um canal com este nome.");
        }

    }
}
