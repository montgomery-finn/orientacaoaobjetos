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
using System.Globalization;

namespace Apresentacao.Visualizacao
{
    public partial class ConsultaVisualizar : Form
    {
        AgendaConsultasServico servico = new AgendaConsultasServico();

        public ConsultaVisualizar()
        {
            InitializeComponent();
            PreecherTodos();
        }

        private void PreecherTodos()
        {
            PreencherDataGridConsulta(servico.Obter());
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            Hide();
            visualizar.ShowDialog();
        }

        private void PreencherDataGridConsulta(List<AgendaConsultas> consulta)
        {
            consultaDataGridView.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            foreach (var item in consulta)
            {
                contLinha = consultaDataGridView.Rows.Add();
                consultaDataGridView.Rows[contLinha].Cells[0].Value = item.AnimalID;
                consultaDataGridView.Rows[contLinha].Cells[1].Value = item.Animal.Nome;
                consultaDataGridView.Rows[contLinha].Cells[2].Value = item.MedicoVeterinarioID;
                consultaDataGridView.Rows[contLinha].Cells[3].Value = item.MedicoVeterinario.Nome;
                consultaDataGridView.Rows[contLinha].Cells[4].Value = item.Data.ToShortDateString();
                consultaDataGridView.Rows[contLinha].Cells[5].Value = item.Data.ToShortTimeString();
                consultaDataGridView.Rows[contLinha].Cells[6].Value = item.Preco.ToString(CultureInfo.InvariantCulture) + ",00";
                numResultados++;
            }
            if (numResultados == 0)
                MessageBox.Show("Nâo existe nenhuma Consulta!");

            consultaDataGridView.AutoResizeColumns();
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
                        PreencherDataGridConsulta(servico.Buscar(x => x.AnimalID == Convert.ToInt32(PesquisaTextBox.Text)));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Nome - Animal")
                    {
                        PreencherDataGridConsulta(servico.Buscar(x => x.Animal.Nome == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Nome - Veterinário")
                    {
                        PreencherDataGridConsulta(servico.Buscar(x => x.MedicoVeterinario.Nome == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "ID - Veterinário")
                    {
                        PreencherDataGridConsulta(servico.Buscar(x => x.MedicoVeterinarioID == Convert.ToInt32(PesquisaTextBox.Text)));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Data")
                    {
                        PreencherDataGridConsulta(servico.Buscar(x => x.Data == Convert.ToDateTime(PesquisaTextBox.Text)));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Não exite esta opção em Consulta!");
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
            AgendaConsultas consulta = ConsultaSelecionada();
            if (consulta != null)
            {
                if (MessageBox.Show("Deseja realmente excluir esta Consulta?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    servico.Excluir(consulta);
                    PreecherTodos();
                }
            }
        }

        private AgendaConsultas ConsultaSelecionada()
        {
            try
            {
                int id = Convert.ToInt32(consultaDataGridView.CurrentRow.Cells[0].Value.ToString());
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
            AgendaConsultas consulta = ConsultaSelecionada();
            if (consulta != null)
            {
                ConsultaCadastro clienteCadastro = new ConsultaCadastro(consulta);
                Hide();
                clienteCadastro.ShowDialog();
                Show();
                PreecherTodos();
            }
        }
    }
}
