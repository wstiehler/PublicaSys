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
    public partial class FormConsultaRecorde : Form
    {
        public FormConsultaRecorde()
        {
            InitializeComponent();
        }

        // Linha de código carrega dados na tabela 'publicaSysDatabaseDataSet4.Table'. 
        private void FormConsultaRecorde_Load(object sender, EventArgs e)
        {
           try
            {
                this.tableTableAdapter.Fill(this.publicaSysDatabaseDataSet4.Table);
            }
           catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar-se no DataSet4 !" + ex.Message);
            }

        }

        //Botão para voltar ao formulário anterior. 
        private void btnVoltarPageInicial_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
