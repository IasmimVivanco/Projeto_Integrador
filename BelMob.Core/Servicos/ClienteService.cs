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

        public void Cadastrar(CadastroClienteRequest cliente)
        {
            var user = new Cliente(cliente.Nome, cliente.Sobrenome, cliente.Email, cliente.PassWord);

            var endereco = new Endereco(cliente.Rua, cliente.Cep, cliente.Numero, cliente.Complemento, Enums.TipoEndereco.Residencial, user);

            user.AdicionarEndereco(endereco);

            _clienteRepository.Create(user);
        }

        public List<ClienteResponse> Listar()
        {
            var list = _clienteRepository.GetAll();

            return list.Select(c => ClienteMapper.From(c)).ToList();
        }
    }
}
