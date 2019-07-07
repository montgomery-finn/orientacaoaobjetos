using Entidades.TiposServicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.TiposServicos
{
    public class Caixa
    {
        public long CaixaID { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public double TotalEmCaixa { get; set; }

        public long ContaPagarID { get; set; }
        public virtual ContaPagar ContaPagar { get; set; }

        public Caixa()
        {
        }

        public Caixa(long caixaID, double valor, double totalEmCaixa, long contaPagarID)
        {
            CaixaID = caixaID;
            Data = DateTime.Now ;
            Valor = valor;
            TotalEmCaixa = totalEmCaixa;
            ContaPagarID = contaPagarID;
        }
    }
}
