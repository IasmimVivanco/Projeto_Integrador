using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Interfaces.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace BelMob.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReagendamentoController : ControllerBase
    {
        public IReagendamentoService _reagendamentoService;

        public ReagendamentoController(IReagendamentoService reagendamentoService)
        {
            _reagendamentoService = reagendamentoService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CadastroReagendamentoRequest reagendamento)
        {
            var result = _reagendamentoService.Cadastrar(reagendamento);

            return result ? Ok() : BadRquest();
        }

        [HttpGet]
        public ActionResult<List<ReagendamentoResponse>> GetAll()
        {
            return Ok(_reagendamentoService.Listar());
        }
    }
}
