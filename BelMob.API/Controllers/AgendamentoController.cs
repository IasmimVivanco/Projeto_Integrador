using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Interfaces.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace BelMob.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        public IAgendamentoService _agendamentoService;

        public AgendamentoController(IAgendamentoService agendamentoService)
        {
            _agendamentoService = agendamentoService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CadastroAgendamentoRequest agendamento)
        {
            _agendamentoService.Cadastrar(agendamento);
            return Ok();
        }

        [HttpGet]
        public ActionResult<List<AgendamentoResponse>> GetAll()
        {
            return Ok(_agendamentoService.Listar());
        }
    }
}
