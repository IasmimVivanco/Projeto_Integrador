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

        public void Criar(Agendamento agendamento)
        {
            _context.Add(agendamento);
            _context.SaveChanges();
        }

        public List<Agendamento> Listar()
        {
            return _context.Agendamentos.Include(i => i.Cliente).ToList();
        }
    }
}
