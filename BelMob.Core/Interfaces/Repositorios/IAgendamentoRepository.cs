﻿using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Interfaces.Repositorios
{
    public interface IAgendamentoRepository
    {
        void Criar(Agendamento agendamento);

        List<Agendamento> Listar();
    }
}
