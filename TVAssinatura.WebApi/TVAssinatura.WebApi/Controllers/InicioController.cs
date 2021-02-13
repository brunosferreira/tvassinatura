using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TVAssinatura.WebApi.Controllers
{
    [ApiController, Route("api")]
    public class InicioController : ControllerBase
    {

        public IActionResult Inicio()
        {
            var retorno = new
            {
                Aplicacao = "TVAssinatura",
                Versao = "0.0.0.1",
                DataVersao = new DateTime(2020, 02, 11)
            };

            return Ok(retorno);
        }

    }
}
