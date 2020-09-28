namespace PublicaSys.Forms
{
    partial class FormInsercao
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
            System.Windows.Forms.Label jogoLabel;
            System.Windows.Forms.Label placarLabel;
            System.Windows.Forms.Label mínimo_da_temporadaLabel;
            System.Windows.Forms.Label máximo_da_temporaLabel;
            System.Windows.Forms.Label quebra_recorde_MinLabel;
            System.Windows.Forms.Label quebra_recorde_MáxLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsercao));
            this.btnVoltarPagina = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.publicaSysDatabaseDataSet1 = new PublicaSys.Forms.PublicaSysDatabaseDataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new PublicaSys.Forms.PublicaSysDatabaseDataSet1TableAdapters.TableTableAdapter();
            this.tableAdapterManager = new PublicaSys.Forms.PublicaSysDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.jogoTextBox = new System.Windows.Forms.TextBox();
            this.placarTextBox = new System.Windows.Forms.TextBox();
            this.mínimo_da_temporadaTextBox = new System.Windows.Forms.TextBox();
            this.máximo_da_temporaTextBox = new System.Windows.Forms.TextBox();
            this.quebra_recorde_MinTextBox = new System.Windows.Forms.TextBox();
            this.quebra_recorde_MáxTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdicionarDado = new System.Windows.Forms.ToolStripButton();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            jogoLabel = new System.Windows.Forms.Label();
            placarLabel = new System.Windows.Forms.Label();
            mínimo_da_temporadaLabel = new System.Windows.Forms.Label();
            máximo_da_temporaLabel = new System.Windows.Forms.Label();
            quebra_recorde_MinLabel = new System.Windows.Forms.Label();
            quebra_recorde_MáxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // jogoLabel
            // 
            jogoLabel.AutoSize = true;
            jogoLabel.BackColor = System.Drawing.Color.White;
            jogoLabel.Location = new System.Drawing.Point(12, 49);
            jogoLabel.Name = "jogoLabel";
            jogoLabel.Size = new System.Drawing.Size(33, 13);
            jogoLabel.TabIndex = 2;
            jogoLabel.Text = "Jogo:";
            // 
            // placarLabel
            // 
            placarLabel.AutoSize = true;
            placarLabel.BackColor = System.Drawing.Color.White;
            placarLabel.Location = new System.Drawing.Point(12, 75);
            placarLabel.Name = "placarLabel";
            placarLabel.Size = new System.Drawing.Size(40, 13);
            placarLabel.TabIndex = 4;
            placarLabel.Text = "Placar:";
            // 
            // mínimo_da_temporadaLabel
            // 
            mínimo_da_temporadaLabel.AutoSize = true;
            mínimo_da_temporadaLabel.BackColor = System.Drawing.Color.White;
            mínimo_da_temporadaLabel.Location = new System.Drawing.Point(12, 101);
            mínimo_da_temporadaLabel.Name = "mínimo_da_temporadaLabel";
            mínimo_da_temporadaLabel.Size = new System.Drawing.Size(113, 13);
            mínimo_da_temporadaLabel.TabIndex = 6;
            mínimo_da_temporadaLabel.Text = "Mínimo da temporada:";
            // 
            // máximo_da_temporaLabel
            // 
            máximo_da_temporaLabel.AutoSize = true;
            máximo_da_temporaLabel.BackColor = System.Drawing.Color.White;
            máximo_da_temporaLabel.Location = new System.Drawing.Point(12, 127);
            máximo_da_temporaLabel.Name = "máximo_da_temporaLabel";
            máximo_da_temporaLabel.Size = new System.Drawing.Size(102, 13);
            máximo_da_temporaLabel.TabIndex = 8;
            máximo_da_temporaLabel.Text = "Máximo da tempora:";
            // 
            // quebra_recorde_MinLabel
            // 
            quebra_recorde_MinLabel.AutoSize = true;
            quebra_recorde_MinLabel.BackColor = System.Drawing.Color.White;
            quebra_recorde_MinLabel.Location = new System.Drawing.Point(12, 153);
            quebra_recorde_MinLabel.Name = "quebra_recorde_MinLabel";
            quebra_recorde_MinLabel.Size = new System.Drawing.Size(104, 13);
            quebra_recorde_MinLabel.TabIndex = 10;
            quebra_recorde_MinLabel.Text = "Quebra recorde Min:";
            // 
            // quebra_recorde_MáxLabel
            // 
            quebra_recorde_MáxLabel.AutoSize = true;
            quebra_recorde_MáxLabel.BackColor = System.Drawing.Color.White;
            quebra_recorde_MáxLabel.Location = new System.Drawing.Point(12, 179);
            quebra_recorde_MáxLabel.Name = "quebra_recorde_MáxLabel";
            quebra_recorde_MáxLabel.Size = new System.Drawing.Size(107, 13);
            quebra_recorde_MáxLabel.TabIndex = 12;
            quebra_recorde_MáxLabel.Text = "Quebra recorde Máx:";
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
            this.btnVoltarPagina.Click += new System.EventHandler(this.btnVoltarPagina_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
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
            // jogoTextBox
            // 
            this.jogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Jogo", true));
            this.jogoTextBox.Location = new System.Drawing.Point(131, 46);
            this.jogoTextBox.Name = "jogoTextBox";
            this.jogoTextBox.Size = new System.Drawing.Size(133, 20);
            this.jogoTextBox.TabIndex = 3;
            // 
            // placarTextBox
            // 
            this.placarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Placar", true));
            this.placarTextBox.Location = new System.Drawing.Point(131, 72);
            this.placarTextBox.Name = "placarTextBox";
            this.placarTextBox.Size = new System.Drawing.Size(133, 20);
            this.placarTextBox.TabIndex = 5;
            // 
            // mínimo_da_temporadaTextBox
            // 
            this.mínimo_da_temporadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Mínimo da temporada", true));
            this.mínimo_da_temporadaTextBox.Location = new System.Drawing.Point(131, 98);
            this.mínimo_da_temporadaTextBox.Name = "mínimo_da_temporadaTextBox";
            this.mínimo_da_temporadaTextBox.Size = new System.Drawing.Size(133, 20);
            this.mínimo_da_temporadaTextBox.TabIndex = 7;
            // 
            // máximo_da_temporaTextBox
            // 
            this.máximo_da_temporaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Máximo da tempora", true));
            this.máximo_da_temporaTextBox.Location = new System.Drawing.Point(131, 124);
            this.máximo_da_temporaTextBox.Name = "máximo_da_temporaTextBox";
            this.máximo_da_temporaTextBox.Size = new System.Drawing.Size(133, 20);
            this.máximo_da_temporaTextBox.TabIndex = 9;
            // 
            // quebra_recorde_MinTextBox
            // 
            this.quebra_recorde_MinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Quebra recorde Min", true));
            this.quebra_recorde_MinTextBox.Location = new System.Drawing.Point(131, 150);
            this.quebra_recorde_MinTextBox.Name = "quebra_recorde_MinTextBox";
            this.quebra_recorde_MinTextBox.Size = new System.Drawing.Size(133, 20);
            this.quebra_recorde_MinTextBox.TabIndex = 11;
            // 
            // quebra_recorde_MáxTextBox
            // 
            this.quebra_recorde_MáxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Quebra recorde Máx", true));
            this.quebra_recorde_MáxTextBox.Location = new System.Drawing.Point(131, 176);
            this.quebra_recorde_MáxTextBox.Name = "quebra_recorde_MáxTextBox";
            this.quebra_recorde_MáxTextBox.Size = new System.Drawing.Size(133, 20);
            this.quebra_recorde_MáxTextBox.TabIndex = 13;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAdicionarDado
            // 
            this.btnAdicionarDado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionarDado.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarDado.Image")));
            this.btnAdicionarDado.Name = "btnAdicionarDado";
            this.btnAdicionarDado.RightToLeftAutoMirrorImage = true;
            this.btnAdicionarDado.Size = new System.Drawing.Size(23, 22);
            this.btnAdicionarDado.Text = "Adicionar novo";
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click_4);
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.btnAdicionarDado;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = null;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAdicionarDado,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(727, 25);
            this.tableBindingNavigator.TabIndex = 1;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // FormInsercao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnVoltarPagina;
            this.ClientSize = new System.Drawing.Size(727, 376);
            this.Controls.Add(jogoLabel);
            this.Controls.Add(this.jogoTextBox);
            this.Controls.Add(placarLabel);
            this.Controls.Add(this.placarTextBox);
            this.Controls.Add(mínimo_da_temporadaLabel);
            this.Controls.Add(this.mínimo_da_temporadaTextBox);
            this.Controls.Add(máximo_da_temporaLabel);
            this.Controls.Add(this.máximo_da_temporaTextBox);
            this.Controls.Add(quebra_recorde_MinLabel);
            this.Controls.Add(this.quebra_recorde_MinTextBox);
            this.Controls.Add(quebra_recorde_MáxLabel);
            this.Controls.Add(this.quebra_recorde_MáxTextBox);
            this.Controls.Add(this.tableBindingNavigator);
            this.Controls.Add(this.btnVoltarPagina);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormInsercao";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Inserir Dados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInsercao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publicaSysDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarPagina;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private PublicaSysDatabaseDataSet1 publicaSysDatabaseDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private PublicaSysDatabaseDataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private PublicaSysDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox jogoTextBox;
        private System.Windows.Forms.TextBox placarTextBox;
        private System.Windows.Forms.TextBox mínimo_da_temporadaTextBox;
        private System.Windows.Forms.TextBox máximo_da_temporaTextBox;
        private System.Windows.Forms.TextBox quebra_recorde_MinTextBox;
        private System.Windows.Forms.TextBox quebra_recorde_MáxTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnAdicionarDado;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
    }
}