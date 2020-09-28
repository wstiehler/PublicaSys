namespace PublicaSys.Forms
{
    partial class FormConsultaRecorde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaRecorde));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.publicaSysDatabaseDataSet4 = new PublicaSys.Forms.PublicaSysDatabaseDataSet4();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new PublicaSys.Forms.PublicaSysDatabaseDataSet4TableAdapters.TableTableAdapter();
            this.quebraRecordeMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quebraRecordeMáxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltarPageInicial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quebraRecordeMinDataGridViewTextBoxColumn,
            this.quebraRecordeMáxDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(476, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // publicaSysDatabaseDataSet4
            // 
            this.publicaSysDatabaseDataSet4.DataSetName = "PublicaSysDatabaseDataSet4";
            this.publicaSysDatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.publicaSysDatabaseDataSet4;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // quebraRecordeMinDataGridViewTextBoxColumn
            // 
            this.quebraRecordeMinDataGridViewTextBoxColumn.DataPropertyName = "Quebra recorde Min";
            this.quebraRecordeMinDataGridViewTextBoxColumn.HeaderText = "Quebra recorde Min";
            this.quebraRecordeMinDataGridViewTextBoxColumn.Name = "quebraRecordeMinDataGridViewTextBoxColumn";
            this.quebraRecordeMinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quebraRecordeMáxDataGridViewTextBoxColumn
            // 
            this.quebraRecordeMáxDataGridViewTextBoxColumn.DataPropertyName = "Quebra recorde Máx";
            this.quebraRecordeMáxDataGridViewTextBoxColumn.HeaderText = "Quebra recorde Máx";
            this.quebraRecordeMáxDataGridViewTextBoxColumn.Name = "quebraRecordeMáxDataGridViewTextBoxColumn";
            this.quebraRecordeMáxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnVoltarPageInicial
            // 
            this.btnVoltarPageInicial.Location = new System.Drawing.Point(292, 319);
            this.btnVoltarPageInicial.Name = "btnVoltarPageInicial";
            this.btnVoltarPageInicial.Size = new System.Drawing.Size(178, 23);
            this.btnVoltarPageInicial.TabIndex = 1;
            this.btnVoltarPageInicial.Text = "Voltar para página de consultas";
            this.btnVoltarPageInicial.UseVisualStyleBackColor = true;
            this.btnVoltarPageInicial.Click += new System.EventHandler(this.btnVoltarPageInicial_Click);
            // 
            // FormConsultaRecorde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(719, 354);
            this.Controls.Add(this.btnVoltarPageInicial);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultaRecorde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consulta de Recorde";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormConsultaRecorde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PublicaSysDatabaseDataSet4 publicaSysDatabaseDataSet4;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private PublicaSysDatabaseDataSet4TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn quebraRecordeMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quebraRecordeMáxDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnVoltarPageInicial;
    }
}