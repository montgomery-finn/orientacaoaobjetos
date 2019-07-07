using Apresentacao.Cadastrar;
using Modelo.TiposCadastro;
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
    public partial class Conta : Form
    {
        ContaClienteServico servico = new ContaClienteServico();
        ClienteServico cadastro = new ClienteServico();
        PagamentoServico pagServico = new PagamentoServico();

        public Conta()
        {
            InitializeComponent();
            ComboBox1();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            Hide();
            visualizar.ShowDialog();
        }

        private void ComboBox1()
        {
            foreach (var item in cadastro.Obter())
            {
                NomeClienteComboBox.Items.Add(item.ClienteID + " - " + item.Nome);
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomeClienteComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Cliente!");
                }
                else
                {
                    PreencherDataGridConta(servico.Buscar(x => x.ClienteID == Convert.ToInt32(NomeClienteComboBox.Text.Split(' ')[0])));

                    MessageBox.Show("Busca efetuada com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Buscar " + ex.Message);
            }
        }

        private void PreencherDataGridConta(List<ContaCliente> conta)
        {
            ContaClienteDataGridView.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            foreach (var item in conta)
            {
                contLinha = ContaClienteDataGridView.Rows.Add();
                ContaClienteDataGridView.Rows[contLinha].Cells[0].Value = item.ContaClienteID;
                ContaClienteDataGridView.Rows[contLinha].Cells[1].Value = item.ClienteID;
                ContaClienteDataGridView.Rows[contLinha].Cells[2].Value = item.Cliente.Nome;
                ContaClienteDataGridView.Rows[contLinha].Cells[3].Value = item.DataInicio.ToShortDateString();
                ContaClienteDataGridView.Rows[contLinha].Cells[4].Value = item.TotalPagamento + ",00";
                if (pagServico.Existe(x => x.ContaClienteID == item.ContaClienteID))
                {
                    ContaClienteDataGridView.Rows[contLinha].Cells[5].Style.BackColor = Color.Red;
                    ContaClienteDataGridView.Rows[contLinha].Cells[5].Value = "Pendente";
                }
                else
                {
                    ContaClienteDataGridView.Rows[contLinha].Cells[5].Style.BackColor = Color.Green;
                    ContaClienteDataGridView.Rows[contLinha].Cells[5].Value = "Pago";
                }
                numResultados++;
            }
            if (numResultados == 0)
                MessageBox.Show("Nâo existe nenhuma Conta deste Cliente!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaCliente contaCliente = ClienteSelecionado();
            if (contaCliente != null)
            {
                if (pagServico.Existe(x => x.ContaClienteID == contaCliente.ContaClienteID))
                {
                    ContaPagarCadastro cadastro = new ContaPagarCadastro(contaCliente);
                    Close();
                    cadastro.ShowDialog();
                }
                else
                    MessageBox.Show("O Pagamento desta conta já foi efetuado!");
            }
        }

        private ContaCliente ClienteSelecionado()
        {
            try
            {
                int id = Convert.ToInt32(ContaClienteDataGridView.CurrentRow.Cells[0].Value.ToString());
                return servico.Buscar(x => x.ContaClienteID == Convert.ToInt32(id)).FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cadastro primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
            }
        }

        private void ContaClienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
