using Microsoft.AspNetCore.Mvc;
using ControleAD.Application.Interfaces;

namespace ControleAD.API.Controllers
{
    [ApiController]
    [Route("api/unidades-organizacionais/admin")]
    public class UnidadesOrganizacionaisController : ControllerBase
    {
        private readonly IUnidadeOrganizacionalService _service;

        public UnidadesOrganizacionaisController(IUnidadeOrganizacionalService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var unidades = _service.ObterTodas();
            return Ok(_service.ObterTodas());
        }
    }
}
