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

        private void FormCalculoMax_Load(object sender, EventArgs e)
        {

           
        }

            //Botão para calcular o máximo da temporada. 
        private void btnCalcularMaximo_Click(object sender, EventArgs e)
        {
            try
            {
                int numeromaximo1 = 12;
                int numeromaximo2 = 24;
                int numeromaximo3 = 24;
                int numeromaximo4 = 24;

                double totalmaximo = numeromaximo1 + numeromaximo2 + numeromaximo3 + numeromaximo4;

                txtCalcularMaximo.Text = totalmaximo.ToString();
            }
             catch (Exception ex)
            {
                MessageBox.Show("Erro genérico ao calcular máximo da temporada ! " + ex.Message);
            }
        }
    }
}
