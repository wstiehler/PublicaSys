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
    public partial class FormInsercao : Form
    {
        public FormInsercao()
        {
            InitializeComponent();
        }
        
            //Botão para voltar ao formulário anterior
        private void btnVoltarPagina_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            //Botão para salvar um novo jogo na tabela. 
        private void tableBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.publicaSysDatabaseDataSet1);
            
            MessageBox.Show("Dados salvos com sucesso!");

        }

            // Linha de código carrega dados na tabela 'publicaSysDatabaseDataSet1.Table'. 
        private void FormInsercao_Load(object sender, EventArgs e)
        {
           
            this.tableTableAdapter.Fill(this.publicaSysDatabaseDataSet1.Table);

        }

       
    }
}
