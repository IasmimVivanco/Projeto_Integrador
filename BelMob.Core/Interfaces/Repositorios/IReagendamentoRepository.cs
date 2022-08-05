using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Interfaces.Repositorios
{
    public interface IReagendamentoRepository
    {
        void Create(Agendamento agendamento);

        List<Agendamento> GetAll();

    }
}
