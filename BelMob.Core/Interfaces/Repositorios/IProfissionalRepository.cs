﻿using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Interfaces.Repositorios
{
    public interface IProfissionalRepository
    {
        void Create(Profissional profissional);

        List<Profissional> GetAll();
    }
}