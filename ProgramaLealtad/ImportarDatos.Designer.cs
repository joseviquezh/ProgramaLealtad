namespace ProgramaLealtad
{
    partial class ventanaImportarDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaImportarDatos));
            this.botonVolver = new System.Windows.Forms.Button();
            this.Importar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.buttonUbicarInforme = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonVolver.BackColor = System.Drawing.Color.Crimson;
            this.botonVolver.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.botonVolver.Location = new System.Drawing.Point(-567, 83);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(134, 32);
            this.botonVolver.TabIndex = 25;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            // 
            // Importar
            // 
            this.Importar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Importar.BackColor = System.Drawing.Color.Green;
            this.Importar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Importar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Importar.Location = new System.Drawing.Point(334, 83);
            this.Importar.Name = "Importar";
            this.Importar.Size = new System.Drawing.Size(88, 32);
            this.Importar.TabIndex = 24;
            this.Importar.Text = "Importar";
            this.Importar.UseVisualStyleBackColor = false;
            this.Importar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancelar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Cancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.Black;
            this.Cancelar.Location = new System.Drawing.Point(12, 83);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(88, 32);
            this.Cancelar.TabIndex = 26;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonUbicarInforme
            // 
            this.buttonUbicarInforme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUbicarInforme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonUbicarInforme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbicarInforme.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonUbicarInforme.Location = new System.Drawing.Point(334, 17);
            this.buttonUbicarInforme.Name = "buttonUbicarInforme";
            this.buttonUbicarInforme.Size = new System.Drawing.Size(88, 40);
            this.buttonUbicarInforme.TabIndex = 27;
            this.buttonUbicarInforme.Text = "Ubicar Informe";
            this.buttonUbicarInforme.UseVisualStyleBackColor = false;
            this.buttonUbicarInforme.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 20);
            this.textBox1.TabIndex = 28;
            // 
            // ventanaImportarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 127);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonUbicarInforme);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.Importar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ventanaImportarDatos";
            this.Text = "Importar Datos";
            this.Load += new System.EventHandler(this.ventanaImportarDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button Importar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button buttonUbicarInforme;
        private System.Windows.Forms.TextBox textBox1;

    }
}