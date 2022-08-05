using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Interfaces.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace BelMob.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProfissionalController : ControllerBase
    {
        public IProfissionalService _profissionalService;

        public ProfissionalController(IProfissionalService profissionalService)
        {
            _profissionalService = profissionalService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CadastroProfissionalRequest profissional)
        {
            _profissionalService.Cadastrar(profissional);
            return Ok();
        }

        [HttpGet]
        public ActionResult<List<ProfissionalResponse>> GetAll()
        {
            return Ok(_profissionalService.Listar());
        }
    }
}
