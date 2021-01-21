using System.Collections.Generic;
using System.Linq;
using TVAssinatura.Dados.Contextos;
using TVAssinatura.Dominio.Clientes;
using TVAssinatura.Dominio.Contratos;

namespace TVAssinatura.Dados.Repositorios
{
    public class ContratoRepositorio : RepositorioBase<Contrato>, IContratoRepositorio
    {
        public ContratoRepositorio(ApplicationDbContext context) : base(context)
        {
        }

        public List<Contrato> ObterContratosPorCliente(Cliente cliente)
        {
            var contratos = Context.Set<Contrato>().Where(c => c.Cliente == cliente);
            if (contratos.Any())
                return contratos.ToList();
            
            return null;
        }
    }
}
