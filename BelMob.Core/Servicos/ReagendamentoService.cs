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
    public class ReagendamentoService : IReagendamentoService
    {
        private IAgendamentoRepository agendamentoRepository;

        public ReagendamentoService(IAgendamentoRepository agendamentoRepository)
        {
            this.agendamentoRepository = agendamentoRepository;
        }

        public bool Cadastrar(CadastroReagendamentoRequest reagendamento)
        {
            var agendamentoAnterior = agendamentoRepository.BuscarPorId(reagendamento.IdAgendamentoAnterior);

            var agendamento = reagendamento.Map();
            agendamento.AdicionarCliente(agendamentoAnterior.Cliente);
            agendamento.AdicionarProfissional(agendamentoAnterior.Profissional);

            return agendamentoRepository.Criar(agendamento);
        }

        public List<ReagendamentoResponse> Listar()
        {
            var list = agendamentoRepository.Listar();

            return list.Select(c => c.Map()).ToList();
        }
    }
}
