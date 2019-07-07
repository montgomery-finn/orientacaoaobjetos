using Apresentacao.Cadastrar;
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

namespace Apresentacao.Visualizacao
{
    public partial class ReceitaVisualizar : Form
    {
        ReceitaServico servico = new ReceitaServico();

        public ReceitaVisualizar()
        {
            InitializeComponent();
            PreecherTodos();
        }

        private void PreecherTodos()
        {
            PreencherDataGridReceita(servico.Obter());
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            Hide();
            visualizar.ShowDialog();
        }

        private void PreencherDataGridReceita(List<Receita> receita)
        {
            receitaDataGridView.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            foreach (var item in receita)
            {
                contLinha = receitaDataGridView.Rows.Add();
                receitaDataGridView.Rows[contLinha].Cells[0].Value = item.AnimalID;
                receitaDataGridView.Rows[contLinha].Cells[1].Value = item.Animal.Nome;
                receitaDataGridView.Rows[contLinha].Cells[2].Value = item.MedicoVeterinarioID;
                receitaDataGridView.Rows[contLinha].Cells[3].Value = item.MedicoVeterinario.Nome;
                receitaDataGridView.Rows[contLinha].Cells[4].Value = item.DataConsulta.ToShortDateString();

                numResultados++;
            }
            if (numResultados == 0)
                MessageBox.Show("Nâo existe nenhuma Receita!");

            receitaDataGridView.AutoResizeColumns();
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
                        PreencherDataGridReceita(servico.Buscar(x => x.AnimalID == Convert.ToInt32(PesquisaTextBox.Text)));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Nome - Animal")
                    {
                        PreencherDataGridReceita(servico.Buscar(x => x.Animal.Nome == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Nome - Veterinário")
                    {
                        PreencherDataGridReceita(servico.Buscar(x => x.MedicoVeterinario.Nome == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "ID - Veterinário")
                    {
                        PreencherDataGridReceita(servico.Buscar(x => x.MedicoVeterinarioID == Convert.ToInt32(PesquisaTextBox.Text)));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Data")
                    {
                        PreencherDataGridReceita(servico.Buscar(x => x.DataConsulta == Convert.ToDateTime(PesquisaTextBox.Text)));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Não exite esta opção em Receita!");
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
            Receita receita = ReceitaSelecionada();
            if (receita != null)
            {
                if (MessageBox.Show("Deseja realmente excluir esta Receita?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    servico.Excluir(receita);
                    PreecherTodos();
                }
            }
        }

        private Receita ReceitaSelecionada()
        {
            try
            {
                int id = Convert.ToInt32(receitaDataGridView.CurrentRow.Cells[0].Value.ToString());
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
            Receita receita = ReceitaSelecionada();
            if (receita != null)
            {
                ReceitaCadastrar receitaCadastrar = new ReceitaCadastrar(receita);
                Hide();
                receitaCadastrar.ShowDialog();
                Show();
                PreecherTodos();
            }
        }
    }
}
