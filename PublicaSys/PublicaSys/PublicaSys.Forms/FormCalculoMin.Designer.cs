namespace PublicaSys.Forms
{
    partial class FormCalculoMin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculoMin));
            this.btnVoltarPagina = new System.Windows.Forms.Button();
            this.txtCalcularMinimo = new System.Windows.Forms.TextBox();
            this.btnCalcularMinimo = new System.Windows.Forms.Button();
            this.dgvMinTemporada = new System.Windows.Forms.DataGridView();
            this.publicaSysDatabaseDataSet6 = new PublicaSys.Forms.PublicaSysDatabaseDataSet6();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new PublicaSys.Forms.PublicaSysDatabaseDataSet6TableAdapters.TableTableAdapter();
            this.mínimoDaTemporadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinTemporada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
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
            // txtCalcularMinimo
            // 
            this.txtCalcularMinimo.Location = new System.Drawing.Point(179, 80);
            this.txtCalcularMinimo.Name = "txtCalcularMinimo";
            this.txtCalcularMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtCalcularMinimo.TabIndex = 1;
            // 
            // btnCalcularMinimo
            // 
            this.btnCalcularMinimo.Location = new System.Drawing.Point(13, 78);
            this.btnCalcularMinimo.Name = "btnCalcularMinimo";
            this.btnCalcularMinimo.Size = new System.Drawing.Size(160, 23);
            this.btnCalcularMinimo.TabIndex = 2;
            this.btnCalcularMinimo.Text = "Calcular mínimo da temporada";
            this.btnCalcularMinimo.UseVisualStyleBackColor = true;
            this.btnCalcularMinimo.Click += new System.EventHandler(this.btnCalcularMinimo_Click);
            // 
            // dgvMinTemporada
            // 
            this.dgvMinTemporada.AllowUserToAddRows = false;
            this.dgvMinTemporada.AllowUserToDeleteRows = false;
            this.dgvMinTemporada.AutoGenerateColumns = false;
            this.dgvMinTemporada.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMinTemporada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMinTemporada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mínimoDaTemporadaDataGridViewTextBoxColumn});
            this.dgvMinTemporada.DataSource = this.tableBindingSource;
            this.dgvMinTemporada.Location = new System.Drawing.Point(564, 40);
            this.dgvMinTemporada.Name = "dgvMinTemporada";
            this.dgvMinTemporada.ReadOnly = true;
            this.dgvMinTemporada.Size = new System.Drawing.Size(143, 302);
            this.dgvMinTemporada.TabIndex = 3;
            this.dgvMinTemporada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMinTemporada_CellContentClick);
            // 
            // publicaSysDatabaseDataSet6
            // 
            this.publicaSysDatabaseDataSet6.DataSetName = "PublicaSysDatabaseDataSet6";
            this.publicaSysDatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.publicaSysDatabaseDataSet6;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // mínimoDaTemporadaDataGridViewTextBoxColumn
            // 
            this.mínimoDaTemporadaDataGridViewTextBoxColumn.DataPropertyName = "Mínimo da temporada";
            this.mínimoDaTemporadaDataGridViewTextBoxColumn.HeaderText = "Mínimo da temporada";
            this.mínimoDaTemporadaDataGridViewTextBoxColumn.Name = "mínimoDaTemporadaDataGridViewTextBoxColumn";
            this.mínimoDaTemporadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(523, 24);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(184, 13);
            this.lblAviso.TabIndex = 4;
            this.lblAviso.Text = "Não esqueça de selecionar as linhas!";
            // 
            // FormCalculoMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(719, 354);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.dgvMinTemporada);
            this.Controls.Add(this.btnCalcularMinimo);
            this.Controls.Add(this.txtCalcularMinimo);
            this.Controls.Add(this.btnVoltarPagina);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalculoMin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Calcular Mínimo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCalculoMin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinTemporada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarPagina;
        private System.Windows.Forms.TextBox txtCalcularMinimo;
        private System.Windows.Forms.Button btnCalcularMinimo;
        private System.Windows.Forms.DataGridView dgvMinTemporada;
        private PublicaSysDatabaseDataSet6 publicaSysDatabaseDataSet6;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private PublicaSysDatabaseDataSet6TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mínimoDaTemporadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAviso;
    }
}