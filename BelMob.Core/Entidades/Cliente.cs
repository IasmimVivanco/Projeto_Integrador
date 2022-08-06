using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Entidades
{
    public class Cliente
    {
        public Cliente() { }

        public Cliente(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Enderecos = new List<Endereco>();
        }


        [Key]
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public IList<Endereco> Enderecos { get; private set; }


        public void AdicionarEndereco(Endereco endereco)
        {
            Enderecos.Add(endereco);
        }
    }
}
