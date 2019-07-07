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
    public partial class ConsultaCadastro : Form
    {
        AgendaConsultasServico servico = new AgendaConsultasServico();
        AnimalServico cadastro = new AnimalServico();
        VeterinarioServico vetCadastro = new VeterinarioServico();
        ContaClienteServico contaServico = new ContaClienteServico();
        ClienteServico clienteServico = new ClienteServico();
        private AgendaConsultas _consulta;

        public ConsultaCadastro()
        {
            InitializeComponent();
            ComboBox1();
            ComboBox2();
        }

        public ConsultaCadastro(AgendaConsultas consulta) : this()
        {
            _consulta = consulta;
            FuncaoEditar();
        }

        private void ComboBox1()
        {
            foreach (var item in cadastro.Obter())
            {
                animalComboBox.Items.Add(item.AnimalID + " - " + item.Nome);
            }
        }

        private void ComboBox2()
        {
            foreach (var item in vetCadastro.Obter())
            {
                VetComboBox.Items.Add(item.MedicoVeterinarioID + " - " + item.Nome);
            }
        }

        private DateTime DataHora()
        {
            string auxiliar = consultaDateTimePicker.Text + " " + horarioDateTimePicker.Text;
            DateTime data = DateTime.Parse(auxiliar);
            return data;
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Cadastros cadastros = new Cadastros();
            Hide();
            cadastros.ShowDialog();
        }

        private void FuncaoEditar()
        {
            animalComboBox.Text = _consulta.AnimalID + " - " + _consulta.Animal.Nome;
            VetComboBox.Text = _consulta.MedicoVeterinarioID + " - " + _consulta.MedicoVeterinario.Nome;
            consultaDateTimePicker.Text = _consulta.Data.ToShortDateString();
            horarioDateTimePicker.Text = _consulta.Data.ToShortTimeString();
            precoTextBox.Text = Convert.ToString(_consulta.Preco.ToString(CultureInfo.InvariantCulture));
            TipoComboBox.Text = _consulta.Tipo;
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (animalComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Animal!");
                }
                else if (VetComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Veterinário!");
                }
                else if (consultaDateTimePicker.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Data Consulta!");
                }
                else if (horarioDateTimePicker.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Horário!");
                }
                else if (precoTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Preço!");
                }
                else if (TipoComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Tipo!");
                }
                else
                {
                    if (_consulta != null)
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

        public AgendaConsultas objGerado()
        {
            AgendaConsultas obj = new AgendaConsultas();

            obj.AnimalID = Convert.ToInt64(animalComboBox.Text.Split(' ')[0]);
            obj.MedicoVeterinarioID = Convert.ToInt64(VetComboBox.Text.Split(' ')[0]);
            obj.Data = DataHora();
            obj.DataAgendamento = DateTime.Now;
            obj.Preco = Convert.ToDouble(precoTextBox.Text.ToString(CultureInfo.InvariantCulture));
            obj.Tipo = TipoComboBox.Text;

            return obj;
        }

        private AgendaConsultas objEditado()
        {
            _consulta.AnimalID = Convert.ToInt64(animalComboBox.Text.Split(' ')[0]);
            _consulta.MedicoVeterinarioID = Convert.ToInt64(VetComboBox.Text.Split(' ')[0]);
            _consulta.Data = DataHora();
            _consulta.DataAgendamento = DateTime.Now;
            _consulta.Preco = Convert.ToDouble(precoTextBox.Text.ToString(CultureInfo.InvariantCulture));
            _consulta.Tipo = TipoComboBox.Text;

            return _consulta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            animalComboBox.Text = string.Empty;
            VetComboBox.Text = string.Empty;
            precoTextBox.Text = "";
            TipoComboBox.Text = string.Empty;
        }

        private void animalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
