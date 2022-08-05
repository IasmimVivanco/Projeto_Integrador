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
    public class ReagendamentoRepository : IReagendamentoRepository
    {
        private readonly SistemaContext _context;

        public ReagendamentoRepository(SistemaContext ctx)
        {
            _context = ctx;
        }

        public void Create(Agendamento agendamento)
        {
            _context.Add(agendamento);
            _context.SaveChanges();
        }

        public List<Agendamento> GetAll()
        {
            return _context.Agendamentos.Include(i => i.Cliente).Include(i => i.Profissional).ToList();
        }
    }
}
