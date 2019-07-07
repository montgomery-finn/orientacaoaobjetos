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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros cadastros = new Cadastros();
            Hide();
            cadastros.Show();
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            Hide();
            visualizar.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            Hide();
            agenda.Show();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaixaView caixa = new CaixaView();
            Hide();
            caixa.Show();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            Hide();
            visualizar.Show();
        }
    }
}
