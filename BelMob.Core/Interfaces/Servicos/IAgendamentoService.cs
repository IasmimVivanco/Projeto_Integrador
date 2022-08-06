using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;

namespace BelMob.Core.Interfaces.Servicos
{
    public interface IAgendamentoService
    {
        bool Cadastrar(CadastroAgendamentoRequest agendamento);

        List<AgendamentoResponse> Listar();
    }
}
