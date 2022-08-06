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
            _context.SaveChanges();
        }

        public List<Profissional> Listar()
        {
            return _context.Profissionais.ToList();
        }
    }
}
