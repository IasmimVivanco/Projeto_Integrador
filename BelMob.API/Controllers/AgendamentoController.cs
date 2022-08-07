using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Interfaces.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace BelMob.API.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        public IAgendamentoService _agendamentoService;
        public IClienteService _clienteService;

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
        
        [HttpGet("{Id}")]
        public ActionResult<AgendamentoResponse> BuscarPelaId(int Id)
        {
            return Ok(_agendamentoService.BuscarPorId(Id));
        }
    }
}
