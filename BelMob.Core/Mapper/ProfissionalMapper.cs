using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Mapper
{
    public static class ProfissionalMapper
    {
        public static ProfissionalResponse From(Profissional profissional)
        {
            var dto = new ProfissionalResponse();
            dto.Id = profissional.Id;
            dto.Name = profissional.Nome;
           
            return dto;
        }
    }
}
