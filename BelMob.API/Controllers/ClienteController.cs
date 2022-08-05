using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Interfaces.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace BelMob.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {

        public IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CadastroClienteRequest cliente)
        {
            _clienteService.Cadastrar(cliente);
            return Ok();
        }

        [HttpGet]
        public ActionResult<List<ClienteResponse>> GetAll()
        {
            return Ok(_clienteService.Listar());
        }
    }
}
