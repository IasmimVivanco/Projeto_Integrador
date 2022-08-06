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
    public class ClienteRepository : IClienteRepository
    {
        private readonly SistemaContext _context;

        public ClienteRepository(SistemaContext ctx)
        {
            _context = ctx;
        }

        public void Criar(Cliente cliente)
        {
            _context.Add(cliente);
            _context.SaveChanges();
        }

        public List<Cliente> Listar()
        {
            return _context.Clientes.Include(i => i.Enderecos).ToList();
        }
    }
}
