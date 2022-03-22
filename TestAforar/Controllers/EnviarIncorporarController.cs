using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestAforar.Entities;
using TestAforar.Service.Interfaces;

namespace TestAforar.Controllers
{
    [Route("Procesar")]
    [ApiController]
    public class EnviarIncorporarController : Controller
    {
        private readonly IIncorporador _incorporador;

        public EnviarIncorporarController(IIncorporador incorporador)
        {
            _incorporador = incorporador;
        }

        [HttpPost]
        public async Task<ActionResult> EnviarIncorporar([FromForm] Prestadora prestadora)
        {
            var result = await _incorporador.Incorporar(prestadora);

            if(result.Success)
                return Ok(result);

            return StatusCode(500, result);
        }
    }
}
