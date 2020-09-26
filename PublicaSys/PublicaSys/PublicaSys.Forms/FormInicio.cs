using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicaSys.Forms
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void consultarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsulta fc = new FormConsulta();
            fc.MdiParent = this;
            fc.Show();
        }

        private void inserirDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsercao fi = new FormInsercao();
            fi.MdiParent = this;
            fi.Show();
        }

        private void tabelaDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelaJogos ft = new FormTabelaJogos();
            ft.MdiParent = this;
            ft.Show();
        }

        private void calcularMinimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculoMin fcmin = new FormCalculoMin();
            fcmin.MdiParent = this;
            fcmin.Show();
        }

        private void calcularMaximoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculoMax fcmax = new FormCalculoMax();
            fcmax.MdiParent = this;
            fcmax.Show();
        }
    }
}
