using TVAssinatura.Dominio.Planos;

namespace TVAssinatura.Aplicacao.Planos
{
    public class ConsultaCanalNoPlano
    {
        private readonly IPlanoRepositorio _planoRepositorio;

        public ConsultaCanalNoPlano(IPlanoRepositorio planoRepositorio)
        {
            _planoRepositorio = planoRepositorio;
        }

        public bool EstaNoPlano(int idDoPlano, int idDoCanal)
        {
            return _planoRepositorio.ExisteCanalNoPlano(idDoPlano, idDoCanal);
        }
    }
}
