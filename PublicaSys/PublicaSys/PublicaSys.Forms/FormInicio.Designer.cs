namespace PublicaSys.Forms
{
    partial class FormInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDeJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculosDaTemporadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularMinimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularMaximoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(503, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.tabelasToolStripMenuItem,
            this.calculosToolStripMenuItem,
            this.informaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarDadosToolStripMenuItem,
            this.inserirDadosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarDadosToolStripMenuItem
            // 
            this.consultarDadosToolStripMenuItem.Name = "consultarDadosToolStripMenuItem";
            this.consultarDadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarDadosToolStripMenuItem.Text = "Consultar Jogos";
            this.consultarDadosToolStripMenuItem.Click += new System.EventHandler(this.consultarDadosToolStripMenuItem_Click);
            // 
            // inserirDadosToolStripMenuItem
            // 
            this.inserirDadosToolStripMenuItem.Name = "inserirDadosToolStripMenuItem";
            this.inserirDadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inserirDadosToolStripMenuItem.Text = "Inserir Jogos";
            this.inserirDadosToolStripMenuItem.Click += new System.EventHandler(this.inserirDadosToolStripMenuItem_Click);
            // 
            // tabelasToolStripMenuItem
            // 
            this.tabelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaDeJogosToolStripMenuItem});
            this.tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            this.tabelasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tabelasToolStripMenuItem.Text = "Tabelas";
            // 
            // tabelaDeJogosToolStripMenuItem
            // 
            this.tabelaDeJogosToolStripMenuItem.Name = "tabelaDeJogosToolStripMenuItem";
            this.tabelaDeJogosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabelaDeJogosToolStripMenuItem.Text = "Tabela de Jogos";
            this.tabelaDeJogosToolStripMenuItem.Click += new System.EventHandler(this.tabelaDeJogosToolStripMenuItem_Click);
            // 
            // informaçõesToolStripMenuItem
            // 
            this.informaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildToolStripMenuItem});
            this.informaçõesToolStripMenuItem.Name = "informaçõesToolStripMenuItem";
            this.informaçõesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.informaçõesToolStripMenuItem.Text = "Informações";
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buildToolStripMenuItem.Text = "Build";
            // 
            // calculosToolStripMenuItem
            // 
            this.calculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculosDaTemporadaToolStripMenuItem});
            this.calculosToolStripMenuItem.Name = "calculosToolStripMenuItem";
            this.calculosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.calculosToolStripMenuItem.Text = "Calculos";
            // 
            // calculosDaTemporadaToolStripMenuItem
            // 
            this.calculosDaTemporadaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularMinimoToolStripMenuItem,
            this.calcularMaximoToolStripMenuItem});
            this.calculosDaTemporadaToolStripMenuItem.Name = "calculosDaTemporadaToolStripMenuItem";
            this.calculosDaTemporadaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.calculosDaTemporadaToolStripMenuItem.Text = "Calculos da temporada";
            // 
            // calcularMinimoToolStripMenuItem
            // 
            this.calcularMinimoToolStripMenuItem.Name = "calcularMinimoToolStripMenuItem";
            this.calcularMinimoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calcularMinimoToolStripMenuItem.Text = "Calcular Minimo";
            this.calcularMinimoToolStripMenuItem.Click += new System.EventHandler(this.calcularMinimoToolStripMenuItem_Click);
            // 
            // calcularMaximoToolStripMenuItem
            // 
            this.calcularMaximoToolStripMenuItem.Name = "calcularMaximoToolStripMenuItem";
            this.calcularMaximoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calcularMaximoToolStripMenuItem.Text = "Calcular Maximo";
            this.calcularMaximoToolStripMenuItem.Click += new System.EventHandler(this.calcularMaximoToolStripMenuItem_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(719, 383);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInicio";
            this.Text = "Pública Tecnologia ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaDeJogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculosDaTemporadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularMinimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularMaximoToolStripMenuItem;
    }
}

