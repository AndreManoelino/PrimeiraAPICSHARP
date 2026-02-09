using Microsoft.AspNetCore.Mvc;
using ControleAD.Application.Interfaces;

namespace ControleAD.API.Controllers
{
    [ApiController]
    [Route("api/unidades-organizacionais")]
    public class UnidadeOrganizacionalController : ControllerBase
    {
        private readonly IUnidadeOrganizacionalService _service;

        public UnidadeOrganizacionalController(IUnidadeOrganizacionalService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var unidades = _service.ObterTodas();
            return Ok(unidades);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string nome)
        {
            _service.Criar(nome);
            return Ok(new { mensagem = "Unidade Organizacional criada com sucesso" });
        }
    }
}
