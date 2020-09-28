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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculoMin));
            this.btnVoltarPagina = new System.Windows.Forms.Button();
            this.txtCalcularMinimo = new System.Windows.Forms.TextBox();
            this.btnCalcularMinimo = new System.Windows.Forms.Button();
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
            this.btnVoltarPagina.Click += new System.EventHandler(this.btnVoltarPagina_Click);
            // 
            // txtCalcularMinimo
            // 
            this.txtCalcularMinimo.Location = new System.Drawing.Point(114, 81);
            this.txtCalcularMinimo.Name = "txtCalcularMinimo";
            this.txtCalcularMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtCalcularMinimo.TabIndex = 1;
            // 
            // btnCalcularMinimo
            // 
            this.btnCalcularMinimo.Location = new System.Drawing.Point(13, 78);
            this.btnCalcularMinimo.Name = "btnCalcularMinimo";
            this.btnCalcularMinimo.Size = new System.Drawing.Size(95, 23);
            this.btnCalcularMinimo.TabIndex = 2;
            this.btnCalcularMinimo.Text = "Calcular Mínimo";
            this.btnCalcularMinimo.UseVisualStyleBackColor = true;
            // 
            // FormCalculoMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(719, 354);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarPagina;
        private System.Windows.Forms.TextBox txtCalcularMinimo;
        private System.Windows.Forms.Button btnCalcularMinimo;
    }
}