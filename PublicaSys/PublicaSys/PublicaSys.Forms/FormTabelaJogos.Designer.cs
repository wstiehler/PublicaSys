namespace PublicaSys.Forms
{
    partial class FormTabelaJogos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTabelaJogos));
            this.btnVoltarPagina = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.publicaSysDatabaseDataSet = new PublicaSys.Forms.PublicaSysDatabaseDataSet();
            this.publicaSysDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltarPagina
            // 
            this.btnVoltarPagina.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltarPagina.Location = new System.Drawing.Point(573, 333);
            this.btnVoltarPagina.Name = "btnVoltarPagina";
            this.btnVoltarPagina.Size = new System.Drawing.Size(134, 23);
            this.btnVoltarPagina.TabIndex = 0;
            this.btnVoltarPagina.Text = "Voltar à página inicial";
            this.btnVoltarPagina.UseVisualStyleBackColor = true;
            this.btnVoltarPagina.Click += new System.EventHandler(this.btnVoltarPagina_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.publicaSysDatabaseDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(293, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 315);
            this.dataGridView1.TabIndex = 1;
            // 
            // publicaSysDatabaseDataSet
            // 
            this.publicaSysDatabaseDataSet.DataSetName = "PublicaSysDatabaseDataSet";
            this.publicaSysDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publicaSysDatabaseDataSetBindingSource
            // 
            this.publicaSysDatabaseDataSetBindingSource.DataSource = this.publicaSysDatabaseDataSet;
            this.publicaSysDatabaseDataSetBindingSource.Position = 0;
            // 
            // FormTabelaJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 354);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVoltarPagina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTabelaJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tabela de Jogos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTabelaJogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarPagina;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource publicaSysDatabaseDataSetBindingSource;
        private PublicaSysDatabaseDataSet publicaSysDatabaseDataSet;
    }
}