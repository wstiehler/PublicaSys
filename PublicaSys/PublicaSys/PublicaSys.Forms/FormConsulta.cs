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
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarPagina_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
