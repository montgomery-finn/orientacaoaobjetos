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
    public partial class ExameVisualizar : Form
    {
        ExameServico servico = new ExameServico();

        public ExameVisualizar()
        {
            InitializeComponent();
            PreecherTodos();
        }

        private void PreecherTodos()
        {
            PreencherDataGridExame(servico.Obter());
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            Hide();
            visualizar.ShowDialog();
        }

        private void PreencherDataGridExame(List<Exame> exame)
        {
            exameDataGridView.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            foreach (var item in exame)
            {
                contLinha = exameDataGridView.Rows.Add();
                exameDataGridView.Rows[contLinha].Cells[0].Value = item.AnimalID;
                exameDataGridView.Rows[contLinha].Cells[1].Value = item.Animal.Nome;
                exameDataGridView.Rows[contLinha].Cells[2].Value = item.MedicoVeterinarioID;
                exameDataGridView.Rows[contLinha].Cells[3].Value = item.MedicoVeterinario.Nome;
                exameDataGridView.Rows[contLinha].Cells[4].Value = item.Nome;
                exameDataGridView.Rows[contLinha].Cells[5].Value = item.Data.ToShortDateString();
                exameDataGridView.Rows[contLinha].Cells[6].Value = item.Data.ToShortTimeString();
                exameDataGridView.Rows[contLinha].Cells[7].Value = item.Preco.ToString(CultureInfo.InvariantCulture) + ",00";

                numResultados++;
            }
            if (numResultados == 0)
                MessageBox.Show("Nâo existe nenhum Exame!");

            exameDataGridView.AutoResizeColumns();
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
                    if (BuscarComboBox.Text == "ID - Animal")
                    {
                        PreencherDataGridExame(servico.Buscar(x => x.AnimalID == Convert.ToInt32(PesquisaTextBox.Text)));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Nome - Animal")
                    {
                        PreencherDataGridExame(servico.Buscar(x => x.Animal.Nome == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Nome - Veterinário")
                    {
                        PreencherDataGridExame(servico.Buscar(x => x.MedicoVeterinario.Nome == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "ID - Veterinário")
                    {
                        PreencherDataGridExame(servico.Buscar(x => x.MedicoVeterinarioID == Convert.ToInt32(PesquisaTextBox.Text)));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Data")
                    {
                        PreencherDataGridExame(servico.Buscar(x => x.Data == Convert.ToDateTime(PesquisaTextBox.Text)));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Nome - Exame")
                    {
                        PreencherDataGridExame(servico.Buscar(x => x.Nome == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Não exite esta opção em Exame!");
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
            Exame exame = ExameSelecionado();
            if (exame != null)
            {
                if (MessageBox.Show("Deseja realmente excluir este Exame?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    servico.Excluir(exame);
                    PreecherTodos();
                }
            }
        }

        private Exame ExameSelecionado()
        {
            try
            {
                int id = Convert.ToInt32(exameDataGridView.CurrentRow.Cells[0].Value.ToString());
                return servico.Buscar(x => x.AnimalID == Convert.ToInt32(id)).FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cadastro primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
            }
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            Exame exame = ExameSelecionado();
            if (exame != null)
            {
                ExamesCadastro exameCadastro = new ExamesCadastro(exame);
                Hide();
                exameCadastro.ShowDialog();
                Show();
                PreecherTodos();
            }
        }
    }
}
