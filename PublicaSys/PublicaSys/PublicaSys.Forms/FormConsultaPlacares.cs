﻿using System;
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
    public partial class FormConsultaPlacares : Form
    {
        public FormConsultaPlacares()
        {
            InitializeComponent();
        }

            //Linha de código carrega dados na tabela 'publicaSysDatabaseDataSet3.Table'.
        private void FormConsultaPlacares_Load(object sender, EventArgs e)
        {
            
            this.tableTableAdapter.Fill(this.publicaSysDatabaseDataSet3.Table);

        }
            
            //Botão para voltar ao formulário inicial. 
        private void btnVoltarPageAnterior_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
