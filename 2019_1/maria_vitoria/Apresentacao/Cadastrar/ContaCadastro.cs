using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.TiposCadastro;
using Modelo.TiposServicos;
using Servico.Servicos;

namespace Apresentacao.Cadastrar
{
    public partial class ContaCadastro : Form
    {
        ContaClienteServico servico = new ContaClienteServico();
        ClienteServico cadastro = new ClienteServico();
        ExamesCadastro exame = new ExamesCadastro();
        ConsultaCadastro consulta = new ConsultaCadastro();
        CaixaView caixa = new CaixaView();
        private ContaCliente _conta;

        public ContaCadastro()
        {
            InitializeComponent();
            ComboBox1();
        }

        private void ComboBox1()
        {
            foreach (var item in cadastro.Obter())
            {
                NomeClienteComboBox.Items.Add(item.ClienteID + " - " + item.Nome);
            }
        }

        public ContaCadastro(ContaCliente conta) : this()
        {
            _conta = conta;
            FuncaoEditar();
        }

        public ContaCadastro(string text) : this()
        {
            Text = text;
            PreencherValor();
        }

        private void PreencherValor()
        {
            ValorTotalTextBox.Text = Text;
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Cadastros cadastros = new Cadastros();
            Hide();
            cadastros.ShowDialog();
        }

        private void FuncaoEditar()
        {
            NomeClienteComboBox.Text = _conta.ClienteID + " - " + _conta.Cliente.Nome;
            ContaDateTimePicker.Text = Convert.ToString(_conta.DataInicio);
            ValorTotalTextBox.Text = Convert.ToString(_conta.TotalPagamento);
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomeClienteComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Nome Cliente!");
                }
                else if (ContaDateTimePicker.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Data!");
                }
                else if (ValorTotalTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Valor Total!");
                }
                else
                {
                    if (_conta != null)
                    {
                        servico.Editar(objEditado());
                        MessageBox.Show("Edição efetuada com Sucesso!");
                        Cadastros cadastros = new Cadastros();
                        cadastros.Show();
                        this.Close();
                    }
                    else
                    {
                        servico.Salvar(objGerado());
                        MessageBox.Show("Cadastro efetuado com Sucesso!");
                        Cadastros cadastros = new Cadastros();
                        cadastros.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salva " + ex.Message);
            }
        }

        public ContaCliente objGerado()
        {
            ContaCliente obj = new ContaCliente();
            obj.ClienteID = Convert.ToInt64(NomeClienteComboBox.Text.Split(' ')[0]);
            obj.DataInicio = Convert.ToDateTime(ContaDateTimePicker.Text);
            obj.TotalPagamento = Convert.ToDouble(ValorTotalTextBox.Text);

            return obj;
        }

        private ContaCliente objEditado()
        {
            _conta.ClienteID = Convert.ToInt64(NomeClienteComboBox.Text.Split(' ')[0]);
            _conta.DataInicio = Convert.ToDateTime(ContaDateTimePicker.Text);
            _conta.TotalPagamento = Convert.ToDouble(ValorTotalTextBox.Text);

            return _conta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            NomeClienteComboBox.Text = "";
            ContaDateTimePicker.Text = string.Empty;
            ValorTotalTextBox.Text = "";
        }
    }
}
