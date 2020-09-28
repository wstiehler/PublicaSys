using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
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
            try
            {
                FormInsercao fi = new FormInsercao();
                fi.MdiParent = this;
                fi.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o formulário de inserção!  " + ex.Message);
            }
        }

            //Botão para acessar o formulário de Tabela de Jogos completa utilizando o DataSet1
        private void tabelaDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormTabelaJogos ft = new FormTabelaJogos();
                ft.MdiParent = this;
                ft.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o formulário de Tabela de Jogos!  " + ex.Message);
            }
        }

            //Botão para acessar o formulário de consulta de Cálculo Mínimo
        private void calcularMinimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormCalculoMin fcmin = new FormCalculoMin();
                fcmin.MdiParent = this;
                fcmin.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o formulário de Cálculo Mínimo!  " + ex.Message);
            }
        }

            //Botão para acessar o formulário de consulta de Cálculo Máximo
        private void calcularMaximoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormCalculoMax fcmax = new FormCalculoMax();
                fcmax.MdiParent = this;
                fcmax.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o formulário de Cálculo Máximo!  " + ex.Message);
            }
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

            //Botão para acessar o formulário de consulta de Jogos utilizando o DataSet2.
        private void consultarJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormConsultaJogos fcj = new FormConsultaJogos();
                fcj.MdiParent = this;
                fcj.Show();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o formulário de Consulta de Jogos!  " + ex.Message);
            }
        }

            //Botão para acessar o formulário de consulta de Placares utilizando o DataSet3.
        private void consultarPlacaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormConsultaPlacares fcp = new FormConsultaPlacares();
                fcp.MdiParent = this;
                fcp.Show();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abir o formulário de Consulta de Placares! " + ex.Message);
            }
        }

            //Botão para acessar o formulário de consulta de Recordes utilizando DataSet4.
        private void consultaRecordeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormConsultaRecorde fcr = new FormConsultaRecorde();
                fcr.MdiParent = this;
                fcr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir o formulário de Consulta de Recordes! " + ex.Message);
            }
        }

        private void calcularRecordeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormCalculoRecorde fr = new FormCalculoRecorde();
                fr.MdiParent = this;
                fr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir o formulário de Calculo de Recorde! " + ex.Message);
            }
        }
    }
}
