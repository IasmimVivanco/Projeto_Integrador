using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Mapper
{
    public static class AgendamentoMapper
    {
        public static AgendamentoResponse From(Agendamento agendamento)
        {
            var dto = new AgendamentoResponse();
            dto.Id = agendamento.Id;
            dto.Data = agendamento.Data;
            dto.TipoDeServico = agendamento.TipoDeServico;

            if (agendamento.Cliente != null)
                dto.ClienteResponse = ClienteMapper.From(agendamento.Cliente);


            return dto;

        }
    }
}
