namespace ProgramaLealtad
{
    partial class GenerarReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarReporte));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonUbicarInforme = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Exportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 22);
            this.textBox1.TabIndex = 32;
            // 
            // buttonUbicarInforme
            // 
            this.buttonUbicarInforme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUbicarInforme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonUbicarInforme.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbicarInforme.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonUbicarInforme.Location = new System.Drawing.Point(372, 34);
            this.buttonUbicarInforme.Name = "buttonUbicarInforme";
            this.buttonUbicarInforme.Size = new System.Drawing.Size(50, 22);
            this.buttonUbicarInforme.TabIndex = 31;
            this.buttonUbicarInforme.Text = "...";
            this.buttonUbicarInforme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUbicarInforme.UseVisualStyleBackColor = false;
            this.buttonUbicarInforme.Click += new System.EventHandler(this.buttonUbicarInforme_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancelar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Cancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.Black;
            this.Cancelar.Location = new System.Drawing.Point(12, 80);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(88, 32);
            this.Cancelar.TabIndex = 30;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Exportar
            // 
            this.Exportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exportar.BackColor = System.Drawing.Color.Green;
            this.Exportar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exportar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exportar.Location = new System.Drawing.Point(334, 80);
            this.Exportar.Name = "Exportar";
            this.Exportar.Size = new System.Drawing.Size(88, 32);
            this.Exportar.TabIndex = 29;
            this.Exportar.Text = "Exportar";
            this.Exportar.UseVisualStyleBackColor = false;
            this.Exportar.Click += new System.EventHandler(this.Exportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Dirección donde se guardará el reporte:";
            // 
            // GenerarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonUbicarInforme);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Exportar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerarReporte";
            this.Text = "GenerarReporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUbicarInforme;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Exportar;
        private System.Windows.Forms.Label label1;
    }
}