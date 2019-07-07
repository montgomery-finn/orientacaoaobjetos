using Entidades.TiposServicos;
using Modelo.TiposCadastro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.TiposServicos
{
    public class ContaCliente
    {
        public long ContaClienteID { get; set; }
        public DateTime DataInicio { get; set; }
        public double TotalPagamento { get; set; }

        public long ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }

        public virtual List<AgendaConsultas> AgendaConsultas { get; set; }
        public virtual List<Exame> Exames { get; set; }
        public virtual List<ContaPagar> ContaPagar { get; set; }

        public ContaCliente()
        {

        }

        public ContaCliente (double totalPagamento)
        {
            TotalPagamento = totalPagamento;
        }

        public ContaCliente(long contaClienteID, double totalPagamento, long clienteID)
        {
            ContaClienteID = contaClienteID;
            DataInicio = DateTime.Now;
            TotalPagamento = totalPagamento;
            ClienteID = clienteID;
        }
    }
}
