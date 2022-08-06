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
    public class ProfissionalRepository : IProfissionalRepository
    {
        private readonly SistemaContext _context;

        public ProfissionalRepository(SistemaContext ctx)
        {
            _context = ctx;
        }

        public void Criar(Profissional profissional)
        {
            _context.Add(profissional);
            return _context.SaveChanges() > 0;
        }

        public Profissional BuscarPorId(int id)
        {
            return _context.Profissionais.FirstOrDefault(a => a.Id == id);
        }

        public List<Profissional> Listar()
        {
            return _context.Profissionais.ToList();
        }
    }
}
