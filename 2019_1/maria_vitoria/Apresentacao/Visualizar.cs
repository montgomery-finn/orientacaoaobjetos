using Apresentacao.Visualizacao;
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
    public partial class Visualizar : Form
    {
        public Visualizar()
        {
            InitializeComponent();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pagPrincipal = new PaginaPrincipal();
            Hide();
            pagPrincipal.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteVisualizar cliente = new ClienteVisualizar();
            cliente.Show();
            this.Hide();
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnimalVisualizar animal = new AnimalVisualizar();
            animal.Show();
            this.Hide();
        }

        private void veterinariotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VeterinarioVisualizar vet = new VeterinarioVisualizar();
            vet.Show();
            this.Hide();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaVisualizar consulta = new ConsultaVisualizar();
            consulta.Show();
            this.Hide();
        }

        private void examesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExameVisualizar exame = new ExameVisualizar();
            exame.Show();
            this.Hide();
        }

        private void receitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceitaVisualizar receita = new ReceitaVisualizar();
            receita.Show();
            this.Hide();
        }

        private void contaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            Hide();
            conta.ShowDialog();
        }
    }
}
