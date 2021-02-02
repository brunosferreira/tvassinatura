using System.Collections.Generic;
using TVAssinatura.Dominio._Base;
using TVAssinatura.Dominio.Clientes;

namespace TVAssinatura.Dominio.Contratos
{
    public interface IContratoRepositorio : IRepositorio<Contrato>
    {
        List<Contrato> ObterContratosPorCliente(Cliente cliente);
    }
}
