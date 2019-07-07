using Modelo.TiposCadastro;
using Modelo.TiposServicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.TiposServicos
{
    public class ContaPagar
    {
        public long ContaPagarID { get; set; }
        public DateTime DataCompra { get; set; }
        public double ValorTotal { get; set; }
        public double ValorPago { get; set; }
        public string FormaPagamento { get; set; }
        public int? Parcelas { get; set; }

        public long ContaClienteID { get; set; }
        public virtual ContaCliente ContaCliente { get; set; }

        public virtual List<Caixa> Caixas { get; set; }

        public ContaPagar()
        {
        }

        public ContaPagar(long contaPagarID, DateTime dataCompra, double valorTotal, double valorPago, string formaPagamento, int? parcelas, long contaClienteID)
        {
            ContaPagarID = contaPagarID;
            DataCompra = dataCompra;
            ValorTotal = valorTotal;
            ValorPago = valorPago;
            FormaPagamento = formaPagamento;
            Parcelas = parcelas;
            ContaClienteID = contaClienteID;
        }
    }
}
