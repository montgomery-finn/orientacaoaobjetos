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

namespace Apresentacao.Cadastrar
{
    public partial class AnimalCadastro : Form
    {
        AnimalServico servico = new AnimalServico();
        ClienteServico cadastro = new ClienteServico();
        private Animal _animal;

        public AnimalCadastro()
        {
            InitializeComponent();
            ComboBox1();
        }

        public AnimalCadastro(Animal animal) : this()
        {
            _animal = animal;
            FuncaoEditar();
        }

        private void ComboBox1()
        {
            foreach (var item in cadastro.Obter())
            {
                nomeCliente.Items.Add(item.ClienteID + " - " + item.Nome);
            }
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Cadastros cadastros = new Cadastros();
            Hide();
            cadastros.ShowDialog();
        }

        private void FuncaoEditar()
        {
            nomeCliente.Text = _animal.ClienteID + " - " + _animal.Cliente.Nome;
            nomeBox.Text = _animal.Nome;
            DataDateTimePicker.Text = _animal.DataNascimento.ToShortDateString();
            especieBox.Text = _animal.Especie;
            racaBox.Text = _animal.Raca;
            SexoAnimalComboBox.Text = _animal.Sexo;
            PesoTextBox.Text = Convert.ToString(_animal.Peso.ToString(CultureInfo.InvariantCulture));
            TamanhoMaskedTextBox.Text = Convert.ToString(_animal.Tamanho);
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomeCliente.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Nome Cliente!");
                }
                else if (nomeBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Nome!");
                }
                else if (dataNascimento.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Data de Nascimento!");
                }
                else if (especie.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Espécie!");
                }
                else if (raca.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Raça!");
                }
                else if (SexoAnimalComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Sexo!");
                }
                else if (PesoTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Peso!");
                }
                else if (TamanhoMaskedTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Tamanho!");
                }
                else
                {
                    if (_animal != null)
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

        public Animal objGerado()
        {
            Animal obj = new Animal();
            obj.ClienteID = Convert.ToInt64(nomeCliente.Text.Split(' ')[0]);
            obj.Nome = nomeBox.Text;
            obj.DataNascimento = Convert.ToDateTime(DataDateTimePicker.Text);
            obj.Especie = especieBox.Text;
            obj.Raca = racaBox.Text;
            obj.Sexo = SexoAnimalComboBox.Text;
            obj.Tamanho = Convert.ToDouble(TamanhoMaskedTextBox.Text);
            obj.Peso = Convert.ToDouble(PesoTextBox.Text.ToString(CultureInfo.InvariantCulture));

            return obj;
        }

        private Animal objEditado()
        {
            _animal.ClienteID = Convert.ToInt64(nomeCliente.Text.Split(' ')[0]);
            _animal.Nome = nomeBox.Text;
            _animal.DataNascimento = Convert.ToDateTime(DataDateTimePicker.Text);
            _animal.Especie = especieBox.Text;
            _animal.Raca = racaBox.Text;
            _animal.Sexo = SexoAnimalComboBox.Text;
            _animal.Tamanho = Convert.ToDouble(TamanhoMaskedTextBox.Text);
            _animal.Peso = Convert.ToDouble(PesoTextBox.Text.ToString(CultureInfo.InvariantCulture));

            return _animal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            nomeCliente.Text = "";
            nomeBox.Text = "";
            DataDateTimePicker.Text = string.Empty;
            especieBox.Text = "";
            racaBox.Text = "";
            SexoAnimalComboBox.Text = string.Empty;
            TamanhoMaskedTextBox.Text = string.Empty;
            PesoTextBox.Text = string.Empty;
        }
    }
}
