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
        public AgendamentoService(IAgendamentoRepository agendamentoRepository)
        {
            _agendamentoRepository = agendamentoRepository;
        }

        public void Cadastrar(CadastroAgendamentoRequest agendamento)
        {
            var user = new Agendamento(agendamento.Data, agendamento.TipoDeServico);
            var cliente = new Cliente(agendamento.Nome, agendamento.Email, agendamento.PassWord);
           
            user.AdicionarCliente(cliente);
            
            _agendamentoRepository.Criar(user);
        }
        public List<AgendamentoResponse> Listar()
        {
            var list = _agendamentoRepository.Listar();

            return list.Select(c => AgendamentoMapper.From(c)).ToList();
        }
    }
}
