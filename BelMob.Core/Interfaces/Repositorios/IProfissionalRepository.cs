using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelMob.Core.DTOs.Request;

namespace BelMob.Core.Interfaces.Repositorios
{
    public interface IProfissionalRepository
    {
        bool Criar(Profissional profissional);

        Profissional BuscarPorId(int id);

        List<Profissional> Listar();
        Profissional AlterarDados(CadastroProfissionalRequest profissionalRequest, int id);
        Profissional Deletar(int id);
    }
}
