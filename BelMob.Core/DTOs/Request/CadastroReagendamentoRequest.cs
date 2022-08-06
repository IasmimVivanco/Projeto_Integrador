using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelMob.Core.Enums;
using BelMob.Core.Entidades;

namespace BelMob.Core.DTOs.Request
{
    public class CadastroReagendamentoRequest
    {
        public DateTime Data { get; private set; }

        public TipoDeServico TipoDeServico { get; private set; }
        
        public int IdAgendamentoAnterior { get; private set; }
    }
}
