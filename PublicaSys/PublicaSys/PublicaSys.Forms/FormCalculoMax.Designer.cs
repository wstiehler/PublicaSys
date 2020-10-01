namespace PublicaSys.Forms
{
    partial class FormCalculoMax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculoMax));
            this.btnVoltarPagina = new System.Windows.Forms.Button();
            this.btnCalcularMaximo = new System.Windows.Forms.Button();
            this.txtCalcularMaximo = new System.Windows.Forms.TextBox();
            this.dgvMaxTemporada = new System.Windows.Forms.DataGridView();
            this.máximoDaTemporaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publicaSysDatabaseDataSet5 = new PublicaSys.Forms.PublicaSysDatabaseDataSet5();
            this.tableTableAdapter = new PublicaSys.Forms.PublicaSysDatabaseDataSet5TableAdapters.TableTableAdapter();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaxTemporada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltarPagina
            // 
            this.btnVoltarPagina.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltarPagina.Location = new System.Drawing.Point(424, 319);
            this.btnVoltarPagina.Name = "btnVoltarPagina";
            this.btnVoltarPagina.Size = new System.Drawing.Size(134, 23);
            this.btnVoltarPagina.TabIndex = 0;
            this.btnVoltarPagina.Text = "Voltar à página inicial";
            this.btnVoltarPagina.UseVisualStyleBackColor = true;
            this.btnVoltarPagina.Click += new System.EventHandler(this.btnVoltarPagina_Click);
            // 
            // btnCalcularMaximo
            // 
            this.btnCalcularMaximo.Location = new System.Drawing.Point(13, 78);
            this.btnCalcularMaximo.Name = "btnCalcularMaximo";
            this.btnCalcularMaximo.Size = new System.Drawing.Size(167, 23);
            this.btnCalcularMaximo.TabIndex = 1;
            this.btnCalcularMaximo.Text = "Calcular máximo da temporada";
            this.btnCalcularMaximo.UseVisualStyleBackColor = true;
            this.btnCalcularMaximo.Click += new System.EventHandler(this.btnCalcularMaximo_Click);
            // 
            // txtCalcularMaximo
            // 
            this.txtCalcularMaximo.Location = new System.Drawing.Point(186, 80);
            this.txtCalcularMaximo.Name = "txtCalcularMaximo";
            this.txtCalcularMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtCalcularMaximo.TabIndex = 2;
            // 
            // dgvMaxTemporada
            // 
            this.dgvMaxTemporada.AllowUserToAddRows = false;
            this.dgvMaxTemporada.AllowUserToDeleteRows = false;
            this.dgvMaxTemporada.AutoGenerateColumns = false;
            this.dgvMaxTemporada.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMaxTemporada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaxTemporada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.máximoDaTemporaDataGridViewTextBoxColumn});
            this.dgvMaxTemporada.DataSource = this.tableBindingSource;
            this.dgvMaxTemporada.Location = new System.Drawing.Point(564, 40);
            this.dgvMaxTemporada.Name = "dgvMaxTemporada";
            this.dgvMaxTemporada.ReadOnly = true;
            this.dgvMaxTemporada.Size = new System.Drawing.Size(143, 302);
            this.dgvMaxTemporada.TabIndex = 3;
            this.dgvMaxTemporada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaxTemporada_CellContentClick);
            // 
            // máximoDaTemporaDataGridViewTextBoxColumn
            // 
            this.máximoDaTemporaDataGridViewTextBoxColumn.DataPropertyName = "Máximo da tempora";
            this.máximoDaTemporaDataGridViewTextBoxColumn.HeaderText = "Máximo da tempora";
            this.máximoDaTemporaDataGridViewTextBoxColumn.Name = "máximoDaTemporaDataGridViewTextBoxColumn";
            this.máximoDaTemporaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.publicaSysDatabaseDataSet5;
            // 
            // publicaSysDatabaseDataSet5
            // 
            this.publicaSysDatabaseDataSet5.DataSetName = "PublicaSysDatabaseDataSet5";
            this.publicaSysDatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAviso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAviso.Location = new System.Drawing.Point(523, 24);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(186, 15);
            this.lblAviso.TabIndex = 4;
            this.lblAviso.Text = "Não esqueça de selecionar as linhas!";
            // 
            // FormCalculoMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(719, 354);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.dgvMaxTemporada);
            this.Controls.Add(this.txtCalcularMaximo);
            this.Controls.Add(this.btnCalcularMaximo);
            this.Controls.Add(this.btnVoltarPagina);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalculoMax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Calcular Máximo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCalculoMax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaxTemporada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarPagina;
        private System.Windows.Forms.Button btnCalcularMaximo;
        private System.Windows.Forms.TextBox txtCalcularMaximo;
        private System.Windows.Forms.DataGridView dgvMaxTemporada;
        private PublicaSysDatabaseDataSet5 publicaSysDatabaseDataSet5;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private PublicaSysDatabaseDataSet5TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn máximoDaTemporaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAviso;
    }
}