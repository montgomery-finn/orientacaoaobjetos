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

namespace Apresentacao.Visualizacao
{
    public partial class VeterinarioVisualizar : Form
    {
        VeterinarioServico servico = new VeterinarioServico();

        public VeterinarioVisualizar()
        {
            InitializeComponent();
            PreecherTodos();
        }

        private void PreecherTodos()
        {
            PreencherDataGridVet(servico.Obter());
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            Hide();
            visualizar.ShowDialog();
        }

        private void PreencherDataGridVet(List<MedicoVeterinario> veterinario)
        {
            vetDataGridView.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            foreach (var item in veterinario)
            {
                contLinha = vetDataGridView.Rows.Add();
                vetDataGridView.Rows[contLinha].Cells[0].Value = item.MedicoVeterinarioID;
                vetDataGridView.Rows[contLinha].Cells[1].Value = item.Nome;
                vetDataGridView.Rows[contLinha].Cells[2].Value = item.CRMV + "/" + item.EstadoCRMV;
                vetDataGridView.Rows[contLinha].Cells[3].Value = item.Email;
                vetDataGridView.Rows[contLinha].Cells[4].Value = item.Celular;

                numResultados++;
            }
            if (numResultados == 0)
                MessageBox.Show("Nâo existe nenhum Veterinário!");

            vetDataGridView.AutoResizeColumns();
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
                    if (BuscarComboBox.Text == "ID - Veterinário")
                    {
                        PreencherDataGridVet(servico.Buscar(x => x.MedicoVeterinarioID == Convert.ToInt32(PesquisaTextBox.Text)));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Nome - Veterinário")
                    {
                        PreencherDataGridVet(servico.Buscar(x => x.Nome == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "CRMV")
                    {
                        PreencherDataGridVet(servico.Buscar(x => x.CRMV == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Não exite esta opção em Veterinário!");
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
            MedicoVeterinario veterinario = VetSelecionado();
            if (veterinario != null)
            {
                if (MessageBox.Show("Deseja realmente excluir este Veterinário?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    servico.Excluir(veterinario);
                    PreecherTodos();
                }
            }
        }

        private MedicoVeterinario VetSelecionado()
        {
            try
            {
                int id = Convert.ToInt32(vetDataGridView.CurrentRow.Cells[0].Value.ToString());
                return servico.Buscar(x => x.MedicoVeterinarioID == Convert.ToInt32(id)).FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um cadastro primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.None);
                return null;
            }
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            MedicoVeterinario veterinario = VetSelecionado();
            if (veterinario != null)
            {
                VeterinarioCadastro vetCadastro = new VeterinarioCadastro(veterinario);
                Hide();
                vetCadastro.ShowDialog();
                Show();
                PreecherTodos();
            }
        }
    }
}
