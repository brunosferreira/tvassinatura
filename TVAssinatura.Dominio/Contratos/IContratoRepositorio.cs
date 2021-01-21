using System.Collections.Generic;
using TVAssinatura.Dominio.Clientes;

namespace TVAssinatura.Dominio.Contratos
{
    public interface IContratoRepositorio
    {
        List<Contrato> ObterContratosPorCliente(Cliente cliente);
    }
}
