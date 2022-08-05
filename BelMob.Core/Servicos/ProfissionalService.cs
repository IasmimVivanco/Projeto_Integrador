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
    public class ProfissionalService : IProfissionalService
    {
        private IProfissionalRepository _profissionalRepository;

        public ProfissionalService(IProfissionalRepository profissionalRepository)
        {
            _profissionalRepository = profissionalRepository;
        }

        public void Cadastrar(CadastroProfissionalRequest profissional)
        {
            var user = new Profissional(profissional.Nome, profissional.Sobrenome, profissional.Email, profissional.PassWord, profissional.Banco, Enums.TipoDeConta.Corrente, profissional.Conta, profissional.Agencia);

            _profissionalRepository.Create(user);
        }
        public List<ProfissionalResponse> Listar()
        {
            var list = _profissionalRepository.GetAll();

            return list.Select(c => ProfissionalMapper.From(c)).ToList();
        }
    }
}
