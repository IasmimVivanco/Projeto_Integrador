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
        public Cliente(string nome, string sobrenome, string email, string passWord)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            PassWord = passWord;
        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public string PassWord { get; private set; }
        public IList<Endereco> Enderecos { get; private set; }


        public void AdicionarEndereco(Endereco endereco)
        {
            Enderecos.Add(endereco);
        }
    }
}
