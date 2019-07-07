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
    public partial class AnimalVisualizar : Form
    {
        AnimalServico servico = new AnimalServico();

        public AnimalVisualizar()
        {
            InitializeComponent();
            PreecherTodos();
        }

        private void PreecherTodos()
        {
            PreencherDataGridAnimal(servico.Obter());
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            Hide();
            visualizar.ShowDialog();
        }

        private void PreencherDataGridAnimal(List<Animal> animal)
        {
            animalDataGridView.Rows.Clear();
            int contLinha = 0, numResultados = 0;
            foreach (var item in animal)
            {
                contLinha = animalDataGridView.Rows.Add();
                animalDataGridView.Rows[contLinha].Cells[0].Value = item.AnimalID;
                animalDataGridView.Rows[contLinha].Cells[1].Value = item.Nome;
                animalDataGridView.Rows[contLinha].Cells[2].Value = item.Cliente.Nome;
                animalDataGridView.Rows[contLinha].Cells[3].Value = item.Especie;
                animalDataGridView.Rows[contLinha].Cells[4].Value = item.Raca;
                animalDataGridView.Rows[contLinha].Cells[5].Value = item.Peso;
                animalDataGridView.Rows[contLinha].Cells[6].Value = item.Tamanho.ToString(CultureInfo.InvariantCulture);
                numResultados++;
            }
            if (numResultados == 0)
                MessageBox.Show("Nâo existe nenhum Animal!");

            animalDataGridView.AutoResizeColumns();
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
                        PreencherDataGridAnimal(servico.Buscar(x => x.AnimalID == Convert.ToInt32(PesquisaTextBox.Text)));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Nome - Animal")
                    {
                        PreencherDataGridAnimal(servico.Buscar(x => x.Nome == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Nome - Cliente")
                    {
                        PreencherDataGridAnimal(servico.Buscar(x => x.Cliente.Nome == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Espécie")
                    {
                        PreencherDataGridAnimal(servico.Buscar(x => x.Especie == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else if (BuscarComboBox.Text == "Raça")
                    {
                        PreencherDataGridAnimal(servico.Buscar(x => x.Raca == PesquisaTextBox.Text));
                        BuscarComboBox.Text = string.Empty;
                        PesquisaTextBox.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Não exite esta opção em Animal!");
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
            Animal animal = AnimalSelecionado();
            if (animal != null)
            {
                if (MessageBox.Show("Deseja realmente excluir este Animal?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    servico.Excluir(animal);
                    PreecherTodos();
                }
            }
        }

        private Animal AnimalSelecionado()
        {
            try
            {
                int id = Convert.ToInt32(animalDataGridView.CurrentRow.Cells[0].Value.ToString());
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
            Animal animal = AnimalSelecionado();
            if (animal != null)
            {
                AnimalCadastro animalCadastro = new AnimalCadastro(animal);
                Hide();
                animalCadastro.ShowDialog();
                Show();
                PreecherTodos();
            }
        }
    }
}
