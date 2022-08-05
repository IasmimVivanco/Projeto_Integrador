using BelMob.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Interfaces.Repositorios
{
    public interface IClienteRepository
    {
        void Create(Cliente cliente);

        List<Cliente> GetAll();
    }
}
