using BelMob.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Core.Entidades
{
    public class Profissional
    {
        public Profissional() { }
        public Profissional(string nome, string sobrenome, string email, string passWord, string banco, TipoDeConta tipoDeConta, string agencia, string conta)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            PassWord = passWord;
            Banco = banco;
            TipoDeConta = tipoDeConta;
            Agencia = agencia;
            Conta = conta;
        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public string PassWord { get; private set; }
        public string Banco { get; private set; }
        public TipoDeConta TipoDeConta { get; private set; }
        public string Agencia { get; private set; }
        public string Conta { get; private set; }
    }
}
