namespace PublicaSys.Forms
{
    partial class FormConsultaPlacares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaPlacares));
            this.publicaSysDatabaseDataSet2 = new PublicaSys.Forms.PublicaSysDatabaseDataSet2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.publicaSysDatabaseDataSet3 = new PublicaSys.Forms.PublicaSysDatabaseDataSet3();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new PublicaSys.Forms.PublicaSysDatabaseDataSet3TableAdapters.TableTableAdapter();
            this.placarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltarPageAnterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // publicaSysDatabaseDataSet2
            // 
            this.publicaSysDatabaseDataSet2.DataSetName = "PublicaSysDatabaseDataSet2";
            this.publicaSysDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(572, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(143, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // publicaSysDatabaseDataSet3
            // 
            this.publicaSysDatabaseDataSet3.DataSetName = "PublicaSysDatabaseDataSet3";
            this.publicaSysDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.publicaSysDatabaseDataSet3;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // placarDataGridViewTextBoxColumn
            // 
            this.placarDataGridViewTextBoxColumn.DataPropertyName = "Placar";
            this.placarDataGridViewTextBoxColumn.HeaderText = "Placar";
            this.placarDataGridViewTextBoxColumn.Name = "placarDataGridViewTextBoxColumn";
            this.placarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnVoltarPageAnterior
            // 
            this.btnVoltarPageAnterior.Location = new System.Drawing.Point(388, 319);
            this.btnVoltarPageAnterior.Name = "btnVoltarPageAnterior";
            this.btnVoltarPageAnterior.Size = new System.Drawing.Size(178, 23);
            this.btnVoltarPageAnterior.TabIndex = 1;
            this.btnVoltarPageAnterior.Text = "Voltar para página de consultas";
            this.btnVoltarPageAnterior.UseVisualStyleBackColor = true;
            this.btnVoltarPageAnterior.Click += new System.EventHandler(this.btnVoltarPageAnterior_Click);
            // 
            // FormConsultaPlacares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(719, 354);
            this.Controls.Add(this.btnVoltarPageAnterior);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultaPlacares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consultar Placares";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormConsultaPlacares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PublicaSysDatabaseDataSet2 publicaSysDatabaseDataSet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PublicaSysDatabaseDataSet3 publicaSysDatabaseDataSet3;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private PublicaSysDatabaseDataSet3TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn placarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnVoltarPageAnterior;
    }
}