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

namespace Apresentacao.Cadastrar
{
    public partial class ReceitaCadastrar : Form
    {
        ReceitaServico servico = new ReceitaServico();
        VeterinarioServico cadastroVet = new VeterinarioServico();
        AnimalServico cadastroAnimal = new AnimalServico();
        private Receita _receita;

        public ReceitaCadastrar()
        {
            InitializeComponent();
            ComboBox1();
            ComboBox2();
        }

        public ReceitaCadastrar(Receita receita) : this()
        {
            _receita = receita;
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
                veterinarioComboBox.Items.Add(item.MedicoVeterinarioID + " - " + item.Nome);
            }
        }

        private void FuncaoEditar()
        {
            animalComboBox.Text = _receita.AnimalID + " - " + _receita.Animal.Nome;
            veterinarioComboBox.Text = _receita.MedicoVeterinarioID + " - " + _receita.MedicoVeterinario.Nome;
            consultaDateTimePicker.Text = _receita.DataConsulta.ToShortDateString();
            TipoComboBox.Text = _receita.Tipo;
            receitaRichTextBox.Text = _receita.Receitas;
            richTextBox2.Text = _receita.Observacoes;
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
                if (animalComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Animal!");
                }
                else if (veterinarioComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Veterinário!");
                }
                else if (TipoComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Tipo!");
                }
                else if (receitaRichTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Receita!");
                }
                else if (richTextBox2.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Observações!");
                }
                else
                {
                    if (_receita != null)
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

        public Receita objGerado()
        {
            Receita obj = new Receita();

            obj.AnimalID = Convert.ToInt64(animalComboBox.Text.Split(' ')[0]);
            obj.MedicoVeterinarioID = Convert.ToInt64(veterinarioComboBox.Text.Split(' ')[0]);
            obj.DataConsulta = Convert.ToDateTime(consultaDateTimePicker.Text);
            obj.Tipo = TipoComboBox.Text;
            obj.Receitas = receitaRichTextBox.Text;
            obj.Observacoes = richTextBox2.Text;

            return obj;
        }

        private Receita objEditado()
        {
            _receita.AnimalID = Convert.ToInt64(animalComboBox.Text.Split(' ')[0]);
            _receita.MedicoVeterinarioID = Convert.ToInt64(veterinarioComboBox.Text.Split(' ')[0]);
            _receita.DataConsulta = Convert.ToDateTime(consultaDateTimePicker.Text);
            _receita.Tipo = TipoComboBox.Text;
            _receita.Receitas = receitaRichTextBox.Text;
            _receita.Observacoes = richTextBox2.Text;

            return _receita;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            animalComboBox.Text = string.Empty;
            veterinarioComboBox.Text = string.Empty;
            TipoComboBox.Text = string.Empty;
            receitaRichTextBox.Text = string.Empty;
            richTextBox2.Text = string.Empty;
        }
    }
}
