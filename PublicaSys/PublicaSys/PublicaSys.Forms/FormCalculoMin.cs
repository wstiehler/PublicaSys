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
    public partial class FormCalculoMin : Form
    {
        public FormCalculoMin()
        {
            InitializeComponent();
        }

            //Botão para voltar ao formulário inicial. 
        private void btnVoltarPagina_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Linha de código carrega dados na tabela 'publicaSysDatabaseDataSet6.Table'. 
        private void FormCalculoMin_Load(object sender, EventArgs e)
        {
            
            this.tableTableAdapter.Fill(this.publicaSysDatabaseDataSet6.Table);

        }

        //Botão para calcular minimo da temporada. 
        private void btnCalcularMinimo_Click(object sender, EventArgs e)
        {
            try
            {
                int N = 0;
                int soma = 0;
                foreach (DataGridViewCell dgv in dgvMinTemporada.SelectedCells)
                {
                    if (int.TryParse(dgv.Value.ToString(), out soma))
                    {
                        N = +N + soma;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel calcular, selecione mais valores!");
                    }
                }

                txtCalcularMinimo.Text = N.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro genérico de aplicação ! " + ex.Message);
            }

        }

        private void dgvMinTemporada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
