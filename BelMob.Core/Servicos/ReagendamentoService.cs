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
        private IReagendamentoRepository _reagendamentoRepository;
        public ReagendamentoService(IReagendamentoRepository reagendamentoRepository)
        {
            _reagendamentoRepository = reagendamentoRepository;
        }

        public void Cadastrar(CadastroReagendamentoRequest reagendamento)
        {
            var agendamento = new Agendamento(reagendamento.Data, reagendamento.TipoDeServico);
            var cliente = new Cliente(reagendamento.Nome, reagendamento.Email, reagendamento.PassWord);
            var profissional = new Profissional(reagendamento.Nome, reagendamento.Email, reagendamento.PassWord);

            agendamento.AdicionarCliente(cliente);
            agendamento.AdicionarProfissional(profissional);

            _reagendamentoRepository.Criar(agendamento);
        }
        public List<ReagendamentoResponse> Listar()
        {
            var list = _reagendamentoRepository.Listar();

            return list.Select(c => ReagendamentoMapper.From(c)).ToList();
        }
    }
}
