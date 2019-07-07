using Modelo.TiposCadastro;
using Modelo.TiposServicos;
using Servico.Servicos;
using System;
using System.Globalization;
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
    public partial class ExamesCadastro : Form
    {
        ExameServico servico = new ExameServico();
        VeterinarioServico cadastroVet = new VeterinarioServico();
        AnimalServico cadastroAnimal = new AnimalServico();
        ContaClienteServico contaServico = new ContaClienteServico();
        ClienteServico clienteServico = new ClienteServico();
        private Exame _exame;

        public ExamesCadastro()
        {
            InitializeComponent();
            ComboBox1();
            ComboBox2();
        }

        public ExamesCadastro(Exame exame) : this()
        {
            _exame = exame;
            FuncaoEditar();
        }

        private void ComboBox1()
        {
            foreach (var item in cadastroAnimal.Obter())
            {
                animalComboBox.Items.Add(item.AnimalID + " - " + item.Nome);
            }
        }

        private void ComboBox2()
        {
            foreach (var item in cadastroVet.Obter())
            {
                medicoComboBox.Items.Add(item.MedicoVeterinarioID + " - " + item.Nome);
            }
        }

        private DateTime DataHora()
        {
            string auxiliar = exameDateTimePicker.Text + " " + horarioDateTimePicker.Text;
            DateTime data = DateTime.Parse(auxiliar);
            return data;
        }

        private void FuncaoEditar()
        {
            nomeExameTextBox.Text = _exame.Nome;
            precoTextBox.Text = Convert.ToString(_exame.Preco.ToString(CultureInfo.InvariantCulture));
            exameDateTimePicker.Text = _exame.Data.ToShortDateString();
            horarioDateTimePicker.Text = _exame.Data.ToShortTimeString();
            animalComboBox.Text = _exame.AnimalID + " - " + _exame.Animal.Nome;
            medicoComboBox.Text = _exame.MedicoVeterinarioID + " - " + _exame.MedicoVeterinario.Nome;
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Cadastros cadastros = new Cadastros();
            Hide();
            cadastros.ShowDialog();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomeExameTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Nome do Exame!");
                }
                else if (precoTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Data Preço!");
                }
                else if (exameDateTimePicker.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Data do Exame!");
                }
                else if (horarioDateTimePicker.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Horário!");
                }
                else if (animalComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Animal!");
                }
                else if (medicoComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Médico!");
                }
                else
                {
                    if (_exame != null)
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
                        ContaCadastro cadastros = new ContaCadastro(precoTextBox.Text);
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

        public Exame objGerado()
        {
            Exame obj = new Exame();

            obj.Nome = nomeExameTextBox.Text;
            obj.Data = DataHora();
            obj.DataAgendamento = DateTime.Now;
            obj.Preco = Convert.ToDouble(precoTextBox.Text.ToString(CultureInfo.InvariantCulture));
            obj.AnimalID = Convert.ToInt64(animalComboBox.Text.Split(' ')[0]);
            obj.MedicoVeterinarioID = Convert.ToInt64(medicoComboBox.Text.Split(' ')[0]);

            return obj;
        }

        private Exame objEditado()
        {
            _exame.Nome = nomeExameTextBox.Text;
            _exame.Data = DataHora();
            _exame.DataAgendamento = DateTime.Now;
            _exame.Preco = Convert.ToDouble(precoTextBox.Text.ToString(CultureInfo.InvariantCulture));
            _exame.AnimalID = Convert.ToInt64(animalComboBox.Text.Split(' ')[0]);
            _exame.MedicoVeterinarioID = Convert.ToInt64(medicoComboBox.Text.Split(' ')[0]);

            return _exame;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            nomeExameTextBox.Text = string.Empty;
            precoTextBox.Text = string.Empty;
            animalComboBox.Text = string.Empty;
            medicoComboBox.Text = string.Empty;
        }
    }
}
