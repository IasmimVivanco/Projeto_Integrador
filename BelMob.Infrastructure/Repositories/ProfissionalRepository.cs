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
    public class ProfissionalRepository : IProfissionalRepository
    {
        private readonly SistemaContext _context;

        public ProfissionalRepository(SistemaContext ctx)
        {
            _context = ctx;
        }

        public bool Criar(Profissional profissional)
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
        public Profissional AlterarDados(CadastroProfissionalRequest profissionalRequest, int id)
        {
            var result = _context.Profissionais.Find(id);
            result.Nome = profissionalRequest.Nome;
            result.Email = profissionalRequest.Email;
            result.Senha = profissionalRequest.Senha;
            result.Banco = profissionalRequest.Banco;
            result.Conta = profissionalRequest.Conta;
            result.TipoDeConta = profissionalRequest.TipoDeConta;
            result.Agencia = profissionalRequest.Agencia;
            _context.SaveChanges();
            return result;
        }
        public Profissional Deletar(int id)
        {
            var profissional = _context.Profissionais.Find(id);
            _context.Remove(profissional);
            _context.SaveChanges();
            return profissional;
        }
    }
}
