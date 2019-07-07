using Apresentacao.Cadastrar;
using Entidades.TiposServicos;
using Modelo.TiposServicos;
using Servico.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class CaixaView : Form
    {
        ContaCliente _conta = new ContaCliente();
        PagamentoServico servico = new PagamentoServico();
        CaixaServico caixaServico = new CaixaServico();
        Caixa caixa = new Caixa();

        public CaixaView()
        {
            InitializeComponent();
            PreencherValorEmCaixa();
        }

        //public CaixaView(string text): this()
        //{
        //    Text = text;
        //}

        private void PreencherValorEmCaixa()
        {
            double atual = caixaServico.Ultimo();
            ValorTotalTextBox.Text = Convert.ToString(atual) + ",00";
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pagPrincipal = new PaginaPrincipal();
            Hide();
            pagPrincipal.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataDateTimePicker.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Data!");
                }
                else
                {
                    PreencherDataGridCaixa(servico.Buscar(x => x.DataCompra == Convert.ToDateTime(DataDateTimePicker.Text)));

                    MessageBox.Show("Busca efetuada com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Buscar " + ex.Message);
            }
        }

        private void PreencherDataGridCaixa(List<ContaPagar> conta)
        {
            CaixaDataGridView.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            foreach (var item in conta)
            {
                contLinha = CaixaDataGridView.Rows.Add();
                CaixaDataGridView.Rows[contLinha].Cells[0].Value = item.ContaClienteID;
                CaixaDataGridView.Rows[contLinha].Cells[1].Value = item.ContaCliente.ClienteID;
                CaixaDataGridView.Rows[contLinha].Cells[2].Value = item.ContaCliente.Cliente.Nome;
                CaixaDataGridView.Rows[contLinha].Cells[3].Value = item.ContaCliente.DataInicio.ToShortDateString();
                CaixaDataGridView.Rows[contLinha].Cells[4].Value = item.ContaCliente.TotalPagamento + ",00";
                CaixaDataGridView.Rows[contLinha].Cells[5].Value = item.ValorPago + ",00";
                CaixaDataGridView.Rows[contLinha].Cells[6].Value = item.FormaPagamento;
                CaixaDataGridView.Rows[contLinha].Cells[7].Value = item.Parcelas;
                numResultados++;
            }
            if (numResultados == 0)
                MessageBox.Show("Nâo existe nenhuma movimentação de Caixa nesta Data!");
        }

        private void ValorTotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
