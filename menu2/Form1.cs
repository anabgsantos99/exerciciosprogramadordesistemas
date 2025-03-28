using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Novo arquivo criado!");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade em construção");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade em construção");
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir arquivo");
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arquivo salvo");
        }

    
    }
}
