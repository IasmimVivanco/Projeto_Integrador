using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Entidades;
using BelMob.Core.Interfaces.Repositorios;
using BelMob.Core.Interfaces.Servicos;
using BelMob.Core.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Servicos
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public bool Cadastrar(CadastroClienteRequest clienteRequest)
        {
            var cliente = clienteRequest.Map();

            return _clienteRepository.Criar(cliente);
        }

        public List<ClienteResponse> Listar()
        {
            var list = _clienteRepository.Listar();

            return list.Select(c => c.Map()).ToList();
        }
    }
}
