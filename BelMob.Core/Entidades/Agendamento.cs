using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelMob.Core.Enums;

namespace BelMob.Core.Entidades
{
    public class Agendamento
    {
        public Agendamento() { }
        public Agendamento(DateTime data, TipoDeServico tipoDeServico)
        {
            Data = data;
            TipoDeServico = tipoDeServico;
            Cliente = new Cliente();
        }

        public Agendamento(DateTime data, TipoDeServico tipoDeServico, Cliente cliente, Profissional? profissional) : this(data, tipoDeServico)
        {
            Cliente = new Cliente();
            Profissional = new Profissional();
        }

        [Key]
        public int Id { get; set; }
        public DateTime Data { get ; set; }
        public TipoDeServico TipoDeServico { get; set; }
        public Cliente Cliente { get; set; }
        public Profissional? Profissional { get; set; }

        public void AdicionarCliente(Cliente cliente)
        {
            this.Cliente = cliente;
        }
        public void AdicionarProfissional(Profissional profissional)
        {
            this.Profissional = profissional;
        }
    }
}
