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

namespace Apresentacao.Cadastrar
{
    public partial class VeterinarioCadastro : Form
    {
        VeterinarioServico servico = new VeterinarioServico();
        private MedicoVeterinario _veterinario;

        public VeterinarioCadastro()
        {
            InitializeComponent();
        }

        public VeterinarioCadastro(MedicoVeterinario veterinario) : this()
        {
            _veterinario = veterinario;
            FuncaoEditar();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Cadastros cadastros = new Cadastros();
            Hide();
            cadastros.ShowDialog();
        }

        private void FuncaoEditar()
        {
            nomeVet.Text = _veterinario.Nome;
            DataNascimento.Text = _veterinario.DataNascimento.ToShortDateString();
            GeneroComboBox.Text = _veterinario.Sexo;
            CPFMaskedTextBox.Text = _veterinario.CPF;
            RGTextBox.Text = _veterinario.RG;
            emailTextBox.Text = _veterinario.Email;
            telMaskedTextBox.Text = _veterinario.Telefone;
            celMaskedTextBox.Text = _veterinario.Celular;
            CRMVTextBox.Text = _veterinario.CRMV;
            esMaskedTextBox.Text = _veterinario.EstadoCRMV;
            espTextBox.Text = _veterinario.Especializacao;
            ruaTextBox.Text = _veterinario.Rua;
            numTextBox.Text = _veterinario.Numero;
            bairroTextBox.Text = _veterinario.Bairro;
            cidadeTextBox.Text = _veterinario.Cidade;
            estadoMaskedTextBox.Text = _veterinario.Estado;
            CEPMaskedTextBox.Text = _veterinario.Cep;

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void CRMVMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void espTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomeVet.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Nome!");
                }
                else if (DataNascimento.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Data de Nascimento!");
                }
                else if (GeneroComboBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Gênero!");
                }
                else if (CPFMaskedTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo CPF!");
                }
                else if (RGTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo RG!");
                }
                else if (emailTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo E-mail!");
                }
                else if (telMaskedTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Telefone!");
                }
                else if (celMaskedTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Celular!");
                }
                else if (ruaTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Rua!");
                }
                else if (numTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Número!");
                }
                else if (bairroTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Bairro!");
                }
                else if (cidadeTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Cidade!");
                }
                else if (estadoMaskedTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Estado!");
                }
                else if (CEPMaskedTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo CEP!");
                }
                else if (CRMVTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo CRMV!");
                }
                else if (estadoMaskedTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Estado!");
                }
                else if (espTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Preencha o campo Especialização!");
                }
                else
                {
                    if (_veterinario != null)
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

        public MedicoVeterinario objGerado()
        {
            MedicoVeterinario obj = new MedicoVeterinario();

            obj.Nome = nomeVet.Text;
            obj.DataNascimento = Convert.ToDateTime(DataNascimento.Text);
            obj.Sexo = GeneroComboBox.Text;
            obj.CPF = CPFMaskedTextBox.Text;
            obj.RG = RGTextBox.Text;
            obj.Email = emailTextBox.Text;
            obj.Telefone = telMaskedTextBox.Text;
            obj.Celular = celMaskedTextBox.Text;
            obj.CRMV = CRMVTextBox.Text;
            obj.EstadoCRMV = esMaskedTextBox.Text;
            obj.Especializacao = espTextBox.Text;
            obj.Rua = ruaTextBox.Text;
            obj.Numero = numTextBox.Text;
            obj.Bairro = bairroTextBox.Text;
            obj.Cidade = cidadeTextBox.Text;
            obj.Estado = estadoMaskedTextBox.Text;
            obj.Cep = CEPMaskedTextBox.Text;

            return obj;
        }

        private MedicoVeterinario objEditado()
        {
            _veterinario.Nome = nomeVet.Text;
            _veterinario.DataNascimento = Convert.ToDateTime(DataNascimento.Text);
            _veterinario.Sexo = GeneroComboBox.Text;
            _veterinario.CPF = CPFMaskedTextBox.Text;
            _veterinario.RG = RGTextBox.Text;
            _veterinario.Email = emailTextBox.Text;
            _veterinario.Telefone = telMaskedTextBox.Text;
            _veterinario.Celular = celMaskedTextBox.Text;
            _veterinario.CRMV = CRMVTextBox.Text;
            _veterinario.EstadoCRMV = esMaskedTextBox.Text;
            _veterinario.Especializacao = espTextBox.Text;
            _veterinario.Rua = ruaTextBox.Text;
            _veterinario.Numero = numTextBox.Text;
            _veterinario.Bairro = bairroTextBox.Text;
            _veterinario.Cidade = cidadeTextBox.Text;
            _veterinario.Estado = estadoMaskedTextBox.Text;
            _veterinario.Cep = CEPMaskedTextBox.Text;

            return _veterinario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            nomeVet.Text = "";
            DataNascimento.Text = string.Empty;
            GeneroComboBox.Text = string.Empty;
            CPFMaskedTextBox.Text = string.Empty;
            RGTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            telMaskedTextBox.Text = string.Empty;
            celMaskedTextBox.Text = string.Empty;
            CRMVTextBox.Text = string.Empty; ;
            esMaskedTextBox.Text = string.Empty;
            espTextBox.Text = string.Empty;
            ruaTextBox.Text = string.Empty;
            numTextBox.Text = string.Empty;
            bairroTextBox.Text = string.Empty;
            cidadeTextBox.Text = string.Empty;
            estadoMaskedTextBox.Text = string.Empty;
            CEPMaskedTextBox.Text = string.Empty;
        }
    }
}
