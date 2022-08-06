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
        public Profissional(string nome, string email, string senha, string banco, TipoDeConta tipoDeConta, string agencia, string conta)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Banco = banco;
            TipoDeConta = tipoDeConta;
            Agencia = agencia;
            Conta = conta;
        }

        public Profissional(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Banco { get; private set; }
        public TipoDeConta TipoDeConta { get; private set; }
        public string Agencia { get; private set; }
        public string Conta { get; private set; }
    }
}
