using BelMob.Core.DTOs.Request;
using BelMob.Core.Entidades;
using BelMob.Core.Interfaces.Repositorios;
using BelMob.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Infrastructure.Repositories
{
    public class AgendamentoRepository : IAgendamentoRepository
    {
        private readonly SistemaContext _context;

        public AgendamentoRepository(SistemaContext ctx)
        {
            _context = ctx;
        }

        public bool Criar(Agendamento agendamento)
        {
            _context.Add(agendamento);
            return _context.SaveChanges() > 0;
        }

        public Agendamento BuscarPorId(int id)
        {
            return _context.Agendamentos.Include(a => a.Cliente).Include(a => a.Cliente.Enderecos).Include(a => a.Profissional).FirstOrDefault(a => a.Id == id);
        }

        public List<Agendamento> Listar()
        {
            return _context.Agendamentos.Include(i => i.Cliente).Include(i => i.Cliente.Enderecos).Include(a => a.Profissional).ToList();
        }
        public List<Agendamento> ListarDisponiveis()
        {
            return _context.Agendamentos.Include(i => i.Cliente).Include(i => i.Cliente.Enderecos).Include(i => i.Profissional).Where(a => a.Profissional == null).ToList();
        }
        public Agendamento AceitarAgendamento(CadastroAgendamentoRequest agendamentoRequest, int id, int IdCliente, int IdProfissional)
        {
            var agendamento = _context.Agendamentos.Find(id);
            agendamento.Data = agendamentoRequest.Data;
            agendamento.TipoDeServico = agendamentoRequest.TipoDeServico;

            var cliente = _context.Clientes.Find(IdCliente);
            agendamento.AdicionarCliente(cliente);
            
            var profissional = _context.Profissionais.Find(IdProfissional);
            agendamento.AdicionarProfissional(profissional);

            _context.Agendamentos.Include(c => c.Cliente).Include(p => p.Profissional).Include(p => p.Cliente.Enderecos);
            _context.SaveChanges();
            return agendamento;
        }
    }
}
