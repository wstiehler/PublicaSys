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
    public partial class FormConsultaJogos : Form
    {
        public FormConsultaJogos()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.publicaSysDatabaseDataSet1);

        }

            //Linha de código carrega dados na tabela 'publicaSysDatabaseDataSet2.Table'.
        private void FormConsultaJogos_Load(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter1.Fill(this.publicaSysDatabaseDataSet2.Table);
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Erro genérico de aplicação DataBase! " + ex.Message);
            }

        }

        private void btnVoltarPageConsulta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
