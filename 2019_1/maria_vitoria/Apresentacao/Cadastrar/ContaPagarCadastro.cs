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

namespace Apresentacao.Cadastrar
{
    public partial class ContaPagarCadastro : Form
    {
        PagamentoServico servico = new PagamentoServico();
        ContaClienteServico cadastro = new ContaClienteServico();
        CaixaServico caixaServico = new CaixaServico();
        private ContaCliente _contaCliente;

        public ContaPagarCadastro(ContaCliente contaCliente)
        {
            InitializeComponent();
            _contaCliente = contaCliente;
            Preencher();
        }

        private void Preencher()
        {
            NomeClienteTextBox.Text = Convert.ToString(_contaCliente.ContaClienteID) + " - " + _contaCliente.Cliente.Nome;
            ValorTotalTextBox.Text = Convert.ToString(_contaCliente.TotalPagamento);
            ParcelasComboBox.SelectedItem = "1";
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            CaixaView caixa = new CaixaView();
            Hide();
            caixa.Show();
        }

        private void NomeClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomeClienteTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Conta Cliente!");
                }
                else if (ContaDateTimePicker.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Data!");
                }
                else if (ValorTotalTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Valor Total!");
                }
                else if (ValorPagoTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Valor Pago!");
                }
                else if (FormaPagComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Forma de Pagamento!");
                }
                else if(FormaPagComboBox.Text == "Cartão - Crédito")
                {
                    MessageBox.Show("Preencha o campo Parcelas!");
                }
                else
                {
                    servico.Salvar(objGerado());
                    AtualizarCaixa();
                    MessageBox.Show("Pagamento efetuado com Sucesso!");
                    CaixaView caixa = new CaixaView();
                    caixa.Show();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salva " + ex.Message);
            }
        }

        private void AtualizarCaixa()
        {
            Caixa caixa = new Caixa();
            caixa.Valor = Convert.ToDouble(ValorPagoTextBox.Text);
            double saldo = caixaServico.Ultimo();
            caixa.TotalEmCaixa = saldo + caixa.Valor;
            caixa.ContaPagarID = servico.Ultimo();
            caixaServico.Salvar(caixa);
        }

        public ContaPagar objGerado()
        {
            ContaPagar obj = new ContaPagar();
            obj.ContaClienteID = Convert.ToInt64(NomeClienteTextBox.Text.Split(' ')[0]);
            obj.DataCompra = Convert.ToDateTime(ContaDateTimePicker.Text);
            obj.ValorTotal = Convert.ToDouble(ValorTotalTextBox.Text);
            obj.ValorPago = Convert.ToDouble(ValorPagoTextBox.Text);
            obj.FormaPagamento = FormaPagComboBox.Text;
            obj.Parcelas = Convert.ToInt32(ParcelasComboBox.Text);

            return obj;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            NomeClienteTextBox.Text = "";
            ContaDateTimePicker.Text = string.Empty;
            ValorTotalTextBox.Text = "";
            ValorPagoTextBox.Text = "";
            FormaPagComboBox.Text = "";
            ParcelasComboBox.Text = "";
        }
    }
}
