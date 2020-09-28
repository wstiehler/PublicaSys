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

        private void btnVoltarPagina_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void FormCalculoMax_Load(object sender, EventArgs e)
        {

           
        }
    
    }
}
