using Apresentacao.Cadastrar;
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
    public partial class Cadastros : Form
    {
        public Cadastros()
        {
            InitializeComponent();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pagPrincipal = new PaginaPrincipal();
            Close();
            pagPrincipal.ShowDialog();
        }

        private void examesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamesCadastro examesCadastro = new ExamesCadastro();
            Hide();
            examesCadastro.ShowDialog();
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnimalCadastro animalCadastro = new AnimalCadastro();
            animalCadastro.Show();
            this.Hide();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteCadastro clienteCadastro = new ClienteCadastro();
            clienteCadastro.Show();
            this.Hide();
        }

        private void veterinariotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VeterinarioCadastro vetCadastro = new VeterinarioCadastro();
            vetCadastro.Show();
            this.Hide();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCadastro consultaCadastro = new ConsultaCadastro();
            consultaCadastro.Show();
            this.Hide();
        }

        private void receitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceitaCadastrar receitaCadastrar = new ReceitaCadastrar();
            receitaCadastrar.Show();
            this.Hide();
        }
    }
}
