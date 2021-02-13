using Microsoft.AspNetCore.Mvc;
using TVAssinatura.Aplicacao.Clientes;

namespace TVAssinatura.WebApi.Controllers
{
    [Route("api/clientes")]
    public class ClienteController : ControllerBase
    {
        private readonly ConsultaCliente _consultaCliente;

        public ClienteController(ConsultaCliente consultaCliente)
        {
            _consultaCliente = consultaCliente;
        }

        [HttpGet, Route("obterPorCpf/{cpfDoCliente}")]
        public IActionResult ObterClientePorCpf(string cpfDoCliente)
        {
            var cliente = _consultaCliente.ObterPorCpf(cpfDoCliente);

            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }
    }
}
