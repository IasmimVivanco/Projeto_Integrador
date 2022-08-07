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
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Banco { get; set; }
        public TipoDeConta TipoDeConta { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
    }
}
