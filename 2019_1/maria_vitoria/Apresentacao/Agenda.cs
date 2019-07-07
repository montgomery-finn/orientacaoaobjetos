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
    public partial class Agenda : Form
    {
        ExameServico exameServico = new ExameServico();
        AgendaConsultasServico consultaServico = new AgendaConsultasServico();

        public Agenda()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pagPrincipal = new PaginaPrincipal();
            Hide();
            pagPrincipal.ShowDialog();
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
                    if (categoriaComboBox.Text == "Consulta")
                    {
                        if (BuscarComboBox.Text == "ID - Animal")
                        {
                            PreencherDataGridConsulta(consultaServico.Buscar(x => x.AnimalID == Convert.ToInt32(PesquisaTextBox.Text)));
                            BuscarComboBox.Text = string.Empty;
                            PesquisaTextBox.Text = string.Empty;
                        }
                        else if (BuscarComboBox.Text == "ID - Veterinário")
                        {
                            PreencherDataGridConsulta(consultaServico.Buscar(x => x.MedicoVeterinarioID == Convert.ToInt32(PesquisaTextBox.Text)));
                            BuscarComboBox.Text = string.Empty;
                            PesquisaTextBox.Text = string.Empty;
                        }
                        else if (BuscarComboBox.Text == "Nome - Animal")
                        {
                            PreencherDataGridConsulta(consultaServico.Buscar(x => x.Animal.Nome == PesquisaTextBox.Text));
                            BuscarComboBox.Text = string.Empty;
                            PesquisaTextBox.Text = string.Empty;
                        }
                        else if (BuscarComboBox.Text == "Nome - Veterinário")
                        {
                            PreencherDataGridConsulta(consultaServico.Buscar(x => x.MedicoVeterinario.Nome == PesquisaTextBox.Text));
                            BuscarComboBox.Text = string.Empty;
                            PesquisaTextBox.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Não exite esta opção em Consulta!");
                        }
                    }
                    else if (categoriaComboBox.Text == "Exame")
                    {
                        if (BuscarComboBox.Text == "ID - Animal")
                        {
                            PreencherDataGridExame(exameServico.Buscar(x => x.AnimalID == Convert.ToInt32(PesquisaTextBox.Text)));
                            BuscarComboBox.Text = string.Empty;
                            PesquisaTextBox.Text = string.Empty;
                        }
                        else if (BuscarComboBox.Text == "ID - Veterinário")
                        {
                            PreencherDataGridExame(exameServico.Buscar(x => x.MedicoVeterinarioID == Convert.ToInt32(PesquisaTextBox.Text)));
                            BuscarComboBox.Text = string.Empty;
                            PesquisaTextBox.Text = string.Empty;
                        }
                        else if (BuscarComboBox.Text == "Nome - Animal")
                        {
                            PreencherDataGridExame(exameServico.Buscar(x => x.Animal.Nome == PesquisaTextBox.Text));
                            BuscarComboBox.Text = string.Empty;
                            PesquisaTextBox.Text = string.Empty;
                        }
                        else if (BuscarComboBox.Text == "Nome - Veterinário")
                        {
                            PreencherDataGridExame(exameServico.Buscar(x => x.MedicoVeterinario.Nome == PesquisaTextBox.Text));
                            BuscarComboBox.Text = string.Empty;
                            PesquisaTextBox.Text = string.Empty;
                        }
                    }
                    MessageBox.Show("Busca efetuada com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salva " + ex.Message);
            }
        }

        private void categoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void PreencherDataGridConsulta(List<AgendaConsultas> consulta)
        {
            agendaDataGridView.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            foreach (var item in consulta)
            {
                contLinha = agendaDataGridView.Rows.Add();
                agendaDataGridView.Rows[contLinha].Cells[0].Value = item.AnimalID;
                agendaDataGridView.Rows[contLinha].Cells[1].Value = item.Animal.Nome;
                agendaDataGridView.Rows[contLinha].Cells[2].Value = item.Data.ToShortDateString();
                agendaDataGridView.Rows[contLinha].Cells[3].Value = item.Data.ToShortTimeString();
                agendaDataGridView.Rows[contLinha].Cells[4].Value = item.Preco + ",00";
                agendaDataGridView.Rows[contLinha].Cells[5].Value = item.Tipo;
                agendaDataGridView.Rows[contLinha].Cells[6].Value = item.MedicoVeterinarioID;        
                agendaDataGridView.Rows[contLinha].Cells[7].Value = item.MedicoVeterinario.Nome;
                numResultados++;
            }
            if (numResultados == 0)
                  MessageBox.Show("Nâo existe nenhuma consulta nesta data!");
        }

        private void PreencherDataGridExame(List<Exame> exame)
        {
            agendaDataGridView.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            foreach (var item in exame)
            {
                contLinha = agendaDataGridView.Rows.Add();
                agendaDataGridView.Rows[contLinha].Cells[0].Value = item.AnimalID;
                agendaDataGridView.Rows[contLinha].Cells[1].Value = item.Data.ToShortDateString();
                agendaDataGridView.Rows[contLinha].Cells[2].Value = item.Data.ToShortTimeString();
                agendaDataGridView.Rows[contLinha].Cells[3].Value = item.Preco;
                agendaDataGridView.Rows[contLinha].Cells[4].Value = item.Nome;
                agendaDataGridView.Rows[contLinha].Cells[5].Value = item.MedicoVeterinarioID;
                agendaDataGridView.Rows[contLinha].Cells[6].Value = item.Animal.Nome;
                agendaDataGridView.Rows[contLinha].Cells[7].Value = item.MedicoVeterinario.Nome;
                numResultados++;
            }
            if (numResultados == 0)
                MessageBox.Show("Nâo existe nenhum exame nesta data!");
        }

        private void BuscarDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoriaComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Categoria!");
                }
                else if (DataDateTimePicker.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Data!");
                }
                else
                {
                    if (categoriaComboBox.Text == "Consulta")
                    {
                        PreencherDataGridConsulta(consultaServico.Buscar(x => x.Data.Date == DataDateTimePicker.Value.Date));
                        MessageBox.Show("Busca efetuada com Sucesso!");
                    }
                    else
                    {
                        PreencherDataGridExame(exameServico.Buscar(x => x.Data.Date == DataDateTimePicker.Value.Date));
                        MessageBox.Show("Busca efetuada com Sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Buscar " + ex.Message);
            }
        }

        private void agendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
