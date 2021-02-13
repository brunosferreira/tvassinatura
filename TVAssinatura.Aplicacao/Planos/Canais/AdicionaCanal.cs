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
            ValidarNomeCanal(canal.Nome);

            _canalRepositorio.Adicionar(canal);

            return canal.Id;
        }

        private void ValidarNomeCanal(string nome)
        {
            var canal = _canalRepositorio.ObterPorNome(nome);
            if (canal != null)
                throw new ArgumentException("Jà existe um canal com este nome.");
        }

    }
}
