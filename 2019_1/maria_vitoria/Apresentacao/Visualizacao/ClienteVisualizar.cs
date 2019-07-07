using Apresentacao.Cadastrar;
using Modelo.TiposCadastro;
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
using System.Globalization;

namespace Apresentacao.Visualizacao
{
    public partial class ClienteVisualizar : Form
    {
        ClienteServico servico = new ClienteServico();

        public ClienteVisualizar()
        {
            InitializeComponent();
            PreecherTodos();
        }

        private void PreecherTodos()
        {
            PreencherDataGridCliente(servico.Obter());
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            Hide();
            visualizar.ShowDialog();
        }

        private void PreencherDataGridCliente(List<Cliente> cliente)
        {
            ClienteDataGridView.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            foreach (var item in cliente)
            {
                contLinha = ClienteDataGridView.Rows.Add();
                ClienteDataGridView.Rows[contLinha].Cells[0].Value = item.ClienteID;
                ClienteDataGridView.Rows[contLinha].Cells[1].Value = item.Nome;
                ClienteDataGridView.Rows[contLinha].Cells[2].Value = item.CPF;
                ClienteDataGridView.Rows[contLinha].Cells[3].Value = item.RG;
                ClienteDataGridView.Rows[contLinha].Cells[4].Value = item.Celular;
                ClienteDataGridView.Rows[contLinha].Cells[5].Value = item.Rua + ", " + item.Numero + ", " + item.Bairro + ", " + item.Cidade;
                numResultados++;
            }
            if (numResultados == 0)
                MessageBox.Show("Nâo existe nenhum Cliente!");

            ClienteDataGridView.AutoResizeColumns();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BuscarComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Buscar por!");
                }
                else if (PesquisaTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Pesquisar!");
                }
                else
                {
                    if (BuscarComboBox.Text == "ID")
                    {
                        PreencherDataGridCliente(servico.Buscar(x => x.ClienteID == Convert.ToInt32(PesquisaTextBox.Text)));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Nome - Cliente")
                    {
                        PreencherDataGridCliente(servico.Buscar(x => x.Nome == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "CPF")
                    {
                        PreencherDataGridCliente(servico.Buscar(x => x.CPF == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "RG")
                    {
                        PreencherDataGridCliente(servico.Buscar(x => x.RG == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Endereço")
                    {
                        PreencherDataGridCliente(servico.Buscar(x => x.Rua == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Não exite esta opção em Cliente!");
                    }
                }
                MessageBox.Show("Busca efetuada com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salva " + ex.Message);
            }
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = ClienteSelecionado();
            if (cliente != null)
            {
                if (MessageBox.Show("Deseja realmente excluir este Cliente?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    servico.Excluir(cliente);
                    PreecherTodos();
                }
            }
        }

        private Cliente ClienteSelecionado()
        {
            try
            {
                int id = Convert.ToInt32(ClienteDataGridView.CurrentRow.Cells[0].Value.ToString());
                return servico.Buscar(x => x.ClienteID == Convert.ToInt32(id)).FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cadastro primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
            }
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = ClienteSelecionado();
            if (cliente != null)
            {
                ClienteCadastro clienteCadastro = new ClienteCadastro(cliente);
                Hide();
                clienteCadastro.ShowDialog();
                Show();
                PreecherTodos();
            }
        }
    }
}
