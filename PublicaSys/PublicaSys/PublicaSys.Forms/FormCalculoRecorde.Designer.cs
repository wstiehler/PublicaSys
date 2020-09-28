namespace PublicaSys.Forms
{
    partial class FormCalculoRecorde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculoRecorde));
            this.btnCalculaRecorde = new System.Windows.Forms.Button();
            this.btnVoltarPagina = new System.Windows.Forms.Button();
            this.txtCalculaRecorde = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculaRecorde
            // 
            this.btnCalculaRecorde.Location = new System.Drawing.Point(13, 78);
            this.btnCalculaRecorde.Name = "btnCalculaRecorde";
            this.btnCalculaRecorde.Size = new System.Drawing.Size(105, 23);
            this.btnCalculaRecorde.TabIndex = 0;
            this.btnCalculaRecorde.Text = "Calcular Recorde";
            this.btnCalculaRecorde.UseVisualStyleBackColor = true;
            // 
            // btnVoltarPagina
            // 
            this.btnVoltarPagina.Location = new System.Drawing.Point(573, 333);
            this.btnVoltarPagina.Name = "btnVoltarPagina";
            this.btnVoltarPagina.Size = new System.Drawing.Size(134, 23);
            this.btnVoltarPagina.TabIndex = 1;
            this.btnVoltarPagina.Text = "Voltar à página inicial";
            this.btnVoltarPagina.UseVisualStyleBackColor = true;
            this.btnVoltarPagina.Click += new System.EventHandler(this.btnVoltarPagina_Click);
            // 
            // txtCalculaRecorde
            // 
            this.txtCalculaRecorde.Location = new System.Drawing.Point(125, 80);
            this.txtCalculaRecorde.Name = "txtCalculaRecorde";
            this.txtCalculaRecorde.Size = new System.Drawing.Size(100, 20);
            this.txtCalculaRecorde.TabIndex = 2;
            // 
            // FormCalculoRecorde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(719, 354);
            this.Controls.Add(this.txtCalculaRecorde);
            this.Controls.Add(this.btnVoltarPagina);
            this.Controls.Add(this.btnCalculaRecorde);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalculoRecorde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Calculo Recorde";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculaRecorde;
        private System.Windows.Forms.Button btnVoltarPagina;
        private System.Windows.Forms.TextBox txtCalculaRecorde;
    }
}