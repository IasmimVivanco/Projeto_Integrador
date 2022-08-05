﻿using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Interfaces.Servicos
{
    public interface IClienteService
    {
        void Cadastrar(CadastroClienteRequest cliente);

        List<ClienteResponse> Listar();
    }
}
