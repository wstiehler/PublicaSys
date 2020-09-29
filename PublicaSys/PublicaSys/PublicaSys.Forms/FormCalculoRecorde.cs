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
    public partial class FormCalculoRecorde : Form
    {
        public FormCalculoRecorde()
        {
            InitializeComponent();
        }

            //Botão para voltar a página anterior. 
        private void btnVoltarPagina_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            //Botão para calcular recordes quebrados. 
        private void btnCalculaRecorde_Click(object sender, EventArgs e)
        {
            try
            {
                int recorde1 = 0;
                int recorde2 = 1;
                int recorde3 = 1;
                int recorde4 = 0;

                double recordequebrado = recorde1 + recorde2 + recorde3 + recorde4;

                txtCalculaRecorde.Text = recordequebrado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro genérico ao calcular recorde! " + ex.Message);
            }
        }

        private void FormCalculoRecorde_Load(object sender, EventArgs e)
        {

        }
    }
}
