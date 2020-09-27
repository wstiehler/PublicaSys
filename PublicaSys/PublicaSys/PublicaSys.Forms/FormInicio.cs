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

             //Botão para acessar o formulário de inserção de dados
        private void inserirDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsercao fi = new FormInsercao();
            fi.MdiParent = this;
            fi.Show();
        }

            //Botão para acessar o formulário de Tabela de Jogos completa utilizando o DataSet1
        private void tabelaDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTabelaJogos ft = new FormTabelaJogos();
            ft.MdiParent = this;
            ft.Show();
        }

            //Botão para acessar o formulário de consulta de Cálculo Mínimo
        private void calcularMinimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculoMin fcmin = new FormCalculoMin();
            fcmin.MdiParent = this;
            fcmin.Show();
        }

            //Botão para acessar o formulário de consulta de Cálculo Máximo
        private void calcularMaximoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculoMax fcmax = new FormCalculoMax();
            fcmax.MdiParent = this;
            fcmax.Show();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

            //Botão para acessar o formulário de consulta de Jogos utilizando o DataSet2.
        private void consultarJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaJogos fcj = new FormConsultaJogos();
            fcj.MdiParent = this;
            fcj.Show();
        }

            //Botão para acessar o formulário de consulta de Placares utilizando o DataSet3.
        private void consultarPlacaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaPlacares fcp = new FormConsultaPlacares();
            fcp.MdiParent = this;
            fcp.Show();
        }
    }
}
