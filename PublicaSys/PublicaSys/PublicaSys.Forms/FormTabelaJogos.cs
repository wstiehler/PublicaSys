using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicaSys.Forms
{
    public partial class FormTabelaJogos : Form
    {
        public FormTabelaJogos()
        {
            InitializeComponent();
        }

        private void btnVoltarPagina_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTabelaJogos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'publicaSysDatabaseDataSet1.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.publicaSysDatabaseDataSet1.Table);

        }
    }
}
