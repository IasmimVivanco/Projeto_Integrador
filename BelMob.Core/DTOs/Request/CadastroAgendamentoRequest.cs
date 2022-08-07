using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelMob.Core.Enums;
using BelMob.Core.Entidades;

namespace BelMob.Core.DTOs.Request
{
    public class CadastroAgendamentoRequest
    {
        public DateTime Data { get; set; }
        public TipoDeServico TipoDeServico { get; set; }
        public int IdCliente { get; set; }

    }
}
