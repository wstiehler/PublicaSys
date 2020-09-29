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

        private void FormCalculoMin_Load(object sender, EventArgs e)
        {

        }

            //Botão para calcular minimo da temporada. 
        private void btnCalcularMinimo_Click(object sender, EventArgs e)
        {
            try
            {
                int numerominimo1 = 12;
                int numerominimo2 = 24;
                int numerominimo3 = 10;
                int numerominimo4 = 24;

                double totalminimo = numerominimo1 + numerominimo2 + numerominimo3 + numerominimo4;

                txtCalcularMinimo.Text = totalminimo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro genérico ao calcular mínimo da temporada ! " + ex.Message);
            }
        }
    }
}
