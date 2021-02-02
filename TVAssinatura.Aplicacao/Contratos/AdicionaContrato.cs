using TVAssinatura.Dominio.Contratos;

namespace TVAssinatura.Aplicacao.Contratos
{
    public class AdicionaContrato
    {
        private readonly IContratoRepositorio _contratoRepositorio;

        public AdicionaContrato(IContratoRepositorio contratoRepositorio)
        {
            _contratoRepositorio = contratoRepositorio;
        }

        public int Adicionar(Contrato contrato)
        {
            if (contrato != null)
                _contratoRepositorio.Adicionar(contrato);
            return contrato.Id;
        }
    }
}
