using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Mapper
{
    public static class ClienteMapper
    {
        public static ClienteResponse From(Cliente cliente)
        {
            var dto = new ClienteResponse();
            dto.Id = cliente.Id;
            dto.Nome = cliente.Nome;

            if (cliente.Enderecos != null)
                dto.Enderecos = cliente.Enderecos.Select(c => EnderecoMapper.From(c)).ToList();


            return dto;

        }
    }
}
