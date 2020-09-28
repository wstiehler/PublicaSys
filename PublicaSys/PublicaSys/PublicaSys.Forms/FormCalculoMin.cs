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
    }
}
