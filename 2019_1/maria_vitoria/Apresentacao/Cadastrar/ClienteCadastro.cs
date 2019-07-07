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
    public partial class ClienteCadastro : Form
    {
        ClienteServico servico = new ClienteServico();
        private Cliente _cliente;

        public ClienteCadastro()
        {
            InitializeComponent();
        }

        public ClienteCadastro(Cliente cliente) : this()
        {
            _cliente = cliente;
            FuncaoEditar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Cadastros cadastros = new Cadastros();
            Hide();
            cadastros.ShowDialog();
        }

        private void FuncaoEditar()
        {
            nomeCliente.Text = _cliente.Nome;
            DataNascimento.Text = _cliente.DataNascimento.ToShortDateString();
            GeneroComboBox.Text = _cliente.Sexo;
            CPFMaskedTextBox.Text = _cliente.CPF;
            RGTextBox.Text = _cliente.RG;
            emailTextBox.Text = _cliente.Email;
            telMaskedTextBox.Text = _cliente.Telefone;
            celMaskedTextBox.Text = _cliente.Celular;
            ruaTextBox.Text = _cliente.Rua;
            numTextBox.Text = _cliente.Numero;
            bairroTextBox.Text = _cliente.Bairro;
            cidadeTextBox.Text = _cliente.Cidade;
            estadoMaskedTextBox.Text = _cliente.Estado;
            CEPMaskedTextBox.Text = _cliente.Cep;

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomeCliente.Text == string.Empty)
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
                else
                {
                    if (_cliente != null)
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

        public Cliente objGerado()
        {
            Cliente obj = new Cliente();

            obj.Nome = nomeCliente.Text;
            obj.DataNascimento = Convert.ToDateTime(DataNascimento.Text);
            obj.Sexo = GeneroComboBox.Text;
            obj.CPF = CPFMaskedTextBox.Text;
            obj.RG = RGTextBox.Text;
            obj.Email = emailTextBox.Text;
            obj.Telefone = telMaskedTextBox.Text;
            obj.Celular = celMaskedTextBox.Text;
            obj.Rua = ruaTextBox.Text;
            obj.Numero = numTextBox.Text;
            obj.Bairro = bairroTextBox.Text;
            obj.Cidade = cidadeTextBox.Text;
            obj.Estado = estadoMaskedTextBox.Text;
            obj.Cep = CEPMaskedTextBox.Text;

            return obj;
        }

        private Cliente objEditado()
        {
            _cliente.Nome = nomeCliente.Text;
            _cliente.DataNascimento = Convert.ToDateTime(DataNascimento.Text);
            _cliente.Sexo = GeneroComboBox.Text;
            _cliente.CPF = CPFMaskedTextBox.Text;
            _cliente.RG = RGTextBox.Text;
            _cliente.Email = emailTextBox.Text;
            _cliente.Telefone = telMaskedTextBox.Text;
            _cliente.Celular = celMaskedTextBox.Text;
            _cliente.Rua = ruaTextBox.Text;
            _cliente.Numero = numTextBox.Text;
            _cliente.Bairro = bairroTextBox.Text;
            _cliente.Cidade = cidadeTextBox.Text;
            _cliente.Estado = estadoMaskedTextBox.Text;
            _cliente.Cep = CEPMaskedTextBox.Text;

            return _cliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            nomeCliente.Text = "";
            DataNascimento.Text = string.Empty;
            GeneroComboBox.Text = string.Empty;
            CPFMaskedTextBox.Text = string.Empty;
            RGTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            telMaskedTextBox.Text = string.Empty;
            celMaskedTextBox.Text = string.Empty;
            ruaTextBox.Text = string.Empty;
            numTextBox.Text = string.Empty;
            bairroTextBox.Text = string.Empty;
            cidadeTextBox.Text = string.Empty;
            estadoMaskedTextBox.Text = string.Empty;
            CEPMaskedTextBox.Text = string.Empty;
        }
    }
}
