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
    public class AgendamentoService : IAgendamentoService
    {
        private IAgendamentoRepository _agendamentoRepository;
        private IClienteRepository _clienteRepository;

        public AgendamentoService(IAgendamentoRepository agendamentoRepository, IClienteRepository clienteRepository)
        {
            _agendamentoRepository = agendamentoRepository;
            _clienteRepository = clienteRepository;
        }

        public Agendamento AceitarAgendamento(AceitarAgendamentoRequest aceitarAgendamento)
        {
            return _agendamentoRepository.AceitarAgendamento(aceitarAgendamento);
        }

        public Agendamento BuscarPorId(int Id)
        {
            return _agendamentoRepository.BuscarPorId(Id);
        }

        public bool Cadastrar(CadastroAgendamentoRequest agendamentoRequest)
        {
            var cliente = _clienteRepository.BuscarPorId(agendamentoRequest.IdCliente);

            var agendamento = agendamentoRequest.Map();

            agendamento.AdicionarCliente(cliente);

            return _agendamentoRepository.Criar(agendamento);
        }
        public List<AgendamentoResponse> Listar()
        {
            var list = _agendamentoRepository.Listar();

            return list.Select(c => AgendamentoMapper.Map(c)).ToList();
        }

        public List<AgendamentoResponse> ListarDisponiveis()
        {
            var list = _agendamentoRepository.ListarDisponiveis();

            return list.Select(c => AgendamentoMapper.Map(c)).ToList();
        }
    }
}
