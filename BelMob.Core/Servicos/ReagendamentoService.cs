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
            var user = new Agendamento(reagendamento.Data, reagendamento.TipoDeServico);
            var cliente = new Cliente(reagendamento.Nome, reagendamento.Sobrenome, reagendamento.Email, reagendamento.PassWord);
            var profissional = new Profissional(reagendamento.Nome, reagendamento.Sobrenome, reagendamento.Email, reagendamento.PassWord);

            user.AdicionarCliente(cliente);
            user.AdicionarProfissional(profissional);

            _reagendamentoRepository.Create(user);
        }
        public List<ReagendamentoResponse> Listar()
        {
            var list = _reagendamentoRepository.GetAll();

            return list.Select(c => ReagendamentoMapper.From(c)).ToList();
        }
    }
}
