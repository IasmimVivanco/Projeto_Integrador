using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Mapper
{
    internal class ReagendamentoMapper
    {
        public static ReagendamentoResponse From(Agendamento reagendamento)
        {
            var dto = new ReagendamentoResponse();
            dto.Id = reagendamento.Id;
            dto.Data = reagendamento.Data;
            dto.TipoDeServico = reagendamento.TipoDeServico;

            if (reagendamento.Cliente != null)
                dto.ClienteResponse = ClienteMapper.From(reagendamento.Cliente);
            
            if (reagendamento.Profissional != null)
                dto.ProfissionalResponse = ProfissionalMapper.From(reagendamento.Profissional);

            return dto;

        }
    }
}
