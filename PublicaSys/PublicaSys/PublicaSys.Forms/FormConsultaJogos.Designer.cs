namespace PublicaSys.Forms
{
    partial class FormConsultaJogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaJogos));
            this.publicaSysDatabaseDataSet1 = new PublicaSys.Forms.PublicaSysDatabaseDataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new PublicaSys.Forms.PublicaSysDatabaseDataSet1TableAdapters.TableTableAdapter();
            this.tableAdapterManager = new PublicaSys.Forms.PublicaSysDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.publicaSysDatabaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.publicaSysDatabaseDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.publicaSysDatabaseDataSet2 = new PublicaSys.Forms.PublicaSysDatabaseDataSet2();
            this.publicaSysDatabaseDataSet = new PublicaSys.Forms.PublicaSysDatabaseDataSet();
            this.publicaSysDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter1 = new PublicaSys.Forms.PublicaSysDatabaseDataSet2TableAdapters.TableTableAdapter();
            this.btnVoltarPageConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // publicaSysDatabaseDataSet1
            // 
            this.publicaSysDatabaseDataSet1.DataSetName = "PublicaSysDatabaseDataSet1";
            this.publicaSysDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.publicaSysDatabaseDataSet1;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = PublicaSys.Forms.PublicaSysDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // publicaSysDatabaseDataSet1BindingSource
            // 
            this.publicaSysDatabaseDataSet1BindingSource.DataSource = this.publicaSysDatabaseDataSet1;
            this.publicaSysDatabaseDataSet1BindingSource.Position = 0;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.publicaSysDatabaseDataSet1BindingSource;
            // 
            // publicaSysDatabaseDataSet1BindingSource1
            // 
            this.publicaSysDatabaseDataSet1BindingSource1.DataSource = this.publicaSysDatabaseDataSet1;
            this.publicaSysDatabaseDataSet1BindingSource1.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jogoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(572, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(143, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // jogoDataGridViewTextBoxColumn
            // 
            this.jogoDataGridViewTextBoxColumn.DataPropertyName = "Jogo";
            this.jogoDataGridViewTextBoxColumn.HeaderText = "Jogo";
            this.jogoDataGridViewTextBoxColumn.Name = "jogoDataGridViewTextBoxColumn";
            this.jogoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableBindingSource2
            // 
            this.tableBindingSource2.DataMember = "Table";
            this.tableBindingSource2.DataSource = this.publicaSysDatabaseDataSet2;
            // 
            // publicaSysDatabaseDataSet2
            // 
            this.publicaSysDatabaseDataSet2.DataSetName = "PublicaSysDatabaseDataSet2";
            this.publicaSysDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // btnVoltarPageConsulta
            // 
            this.btnVoltarPageConsulta.CausesValidation = false;
            this.btnVoltarPageConsulta.Location = new System.Drawing.Point(388, 319);
            this.btnVoltarPageConsulta.Name = "btnVoltarPageConsulta";
            this.btnVoltarPageConsulta.Size = new System.Drawing.Size(178, 23);
            this.btnVoltarPageConsulta.TabIndex = 1;
            this.btnVoltarPageConsulta.Text = "Voltar para página de consultas";
            this.btnVoltarPageConsulta.UseVisualStyleBackColor = true;
            this.btnVoltarPageConsulta.Click += new System.EventHandler(this.btnVoltarPageConsulta_Click);
            // 
            // FormConsultaJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(719, 354);
            this.Controls.Add(this.btnVoltarPageConsulta);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultaJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consultar Jogos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormConsultaJogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PublicaSysDatabaseDataSet1 publicaSysDatabaseDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private PublicaSysDatabaseDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private PublicaSysDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource publicaSysDatabaseDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource publicaSysDatabaseDataSet1BindingSource;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PublicaSysDatabaseDataSet publicaSysDatabaseDataSet;
        private System.Windows.Forms.BindingSource publicaSysDatabaseDataSetBindingSource;
        private PublicaSysDatabaseDataSet2 publicaSysDatabaseDataSet2;
        private System.Windows.Forms.BindingSource tableBindingSource2;
        private PublicaSysDatabaseDataSet2TableAdapters.TableTableAdapter tableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnVoltarPageConsulta;
    }
}