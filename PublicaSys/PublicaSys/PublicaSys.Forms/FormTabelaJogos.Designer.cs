﻿namespace PublicaSys.Forms
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
            this.jogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mínimoDaTemporadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.máximoDaTemporaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quebraRecordeMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quebraRecordeMáxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publicaSysDatabaseDataSet1 = new PublicaSys.Forms.PublicaSysDatabaseDataSet1();
            this.publicaSysDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publicaSysDatabaseDataSet = new PublicaSys.Forms.PublicaSysDatabaseDataSet();
            this.tableTableAdapter = new PublicaSys.Forms.PublicaSysDatabaseDataSet1TableAdapters.TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet)).BeginInit();
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jogoDataGridViewTextBoxColumn,
            this.placarDataGridViewTextBoxColumn,
            this.mínimoDaTemporadaDataGridViewTextBoxColumn,
            this.máximoDaTemporaDataGridViewTextBoxColumn,
            this.quebraRecordeMinDataGridViewTextBoxColumn,
            this.quebraRecordeMáxDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(64, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 266);
            this.dataGridView1.TabIndex = 1;
            // 
            // jogoDataGridViewTextBoxColumn
            // 
            this.jogoDataGridViewTextBoxColumn.DataPropertyName = "Jogo";
            this.jogoDataGridViewTextBoxColumn.HeaderText = "Jogo";
            this.jogoDataGridViewTextBoxColumn.Name = "jogoDataGridViewTextBoxColumn";
            this.jogoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placarDataGridViewTextBoxColumn
            // 
            this.placarDataGridViewTextBoxColumn.DataPropertyName = "Placar";
            this.placarDataGridViewTextBoxColumn.HeaderText = "Placar";
            this.placarDataGridViewTextBoxColumn.Name = "placarDataGridViewTextBoxColumn";
            this.placarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mínimoDaTemporadaDataGridViewTextBoxColumn
            // 
            this.mínimoDaTemporadaDataGridViewTextBoxColumn.DataPropertyName = "Mínimo da temporada";
            this.mínimoDaTemporadaDataGridViewTextBoxColumn.HeaderText = "Mínimo da temporada";
            this.mínimoDaTemporadaDataGridViewTextBoxColumn.Name = "mínimoDaTemporadaDataGridViewTextBoxColumn";
            this.mínimoDaTemporadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // máximoDaTemporaDataGridViewTextBoxColumn
            // 
            this.máximoDaTemporaDataGridViewTextBoxColumn.DataPropertyName = "Máximo da tempora";
            this.máximoDaTemporaDataGridViewTextBoxColumn.HeaderText = "Máximo da tempora";
            this.máximoDaTemporaDataGridViewTextBoxColumn.Name = "máximoDaTemporaDataGridViewTextBoxColumn";
            this.máximoDaTemporaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.publicaSysDatabaseDataSet1;
            // 
            // publicaSysDatabaseDataSet1
            // 
            this.publicaSysDatabaseDataSet1.DataSetName = "PublicaSysDatabaseDataSet1";
            this.publicaSysDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publicaSysDatabaseDataSetBindingSource
            // 
            this.publicaSysDatabaseDataSetBindingSource.DataSource = this.publicaSysDatabaseDataSet;
            this.publicaSysDatabaseDataSetBindingSource.Position = 0;
            // 
            // publicaSysDatabaseDataSet
            // 
            this.publicaSysDatabaseDataSet.DataSetName = "PublicaSysDatabaseDataSet";
            this.publicaSysDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // FormTabelaJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(719, 354);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVoltarPagina);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTabelaJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tabela de Jogos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTabelaJogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarPagina;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource publicaSysDatabaseDataSetBindingSource;
        private PublicaSysDatabaseDataSet publicaSysDatabaseDataSet;
        private PublicaSysDatabaseDataSet1 publicaSysDatabaseDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private PublicaSysDatabaseDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mínimoDaTemporadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn máximoDaTemporaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quebraRecordeMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quebraRecordeMáxDataGridViewTextBoxColumn;
    }
}