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
using System.DirectoryServices;
using System.IO;

namespace PublicaSys.Forms
{
    public partial class FormCalculoMax : Form
    {

        public FormCalculoMax()
        {
            InitializeComponent();
    
        }

              //Botão para voltar ao formulário inicial. 
        private void btnVoltarPagina_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            //Linha de código carrega dados na tabela 'publicaSysDatabaseDataSet5.Table'. 
        private void FormCalculoMax_Load(object sender, EventArgs e)
        {
            
            this.tableTableAdapter.Fill(this.publicaSysDatabaseDataSet5.Table);

            
        }

            //Botão para calcular o máximo da temporada. 
        private void btnCalcularMaximo_Click(object sender, EventArgs e)
        {
            try
            {
                int N = 0;
                int soma = 0;
                foreach (DataGridViewCell dgv in dgvMaxTemporada.SelectedCells)
                {
                    if (int.TryParse(dgv.Value.ToString(), out soma))
                    {
                        N =+ N + soma;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel calcular, selecione mais valores!");
                    }
                }

                txtCalcularMaximo.Text = N.ToString();
            }
             catch (Exception ex)
            {
                MessageBox.Show("Erro genérico de aplicação ! " + ex.Message);
            }
        }

        internal void dgvMaxTemporada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}
