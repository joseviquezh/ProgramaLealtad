namespace ProgramaLealtad
{
    partial class ventanaAgregarDueño
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
            this.textBoxCédulaDueño = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.VentanaAgregarDueno = new System.Windows.Forms.Button();
            this.textBoxTelefonoDueño = new System.Windows.Forms.TextBox();
            this.textBoxNombreDueño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCédulaDueño
            // 
            this.textBoxCédulaDueño.Location = new System.Drawing.Point(112, 163);
            this.textBoxCédulaDueño.Name = "textBoxCédulaDueño";
            this.textBoxCédulaDueño.Size = new System.Drawing.Size(275, 20);
            this.textBoxCédulaDueño.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = "Cédula";
            // 
            // Cancelar
            // 
            this.Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancelar.BackColor = System.Drawing.Color.Crimson;
            this.Cancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Cancelar.Location = new System.Drawing.Point(12, 222);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(104, 32);
            this.Cancelar.TabIndex = 43;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click_1);
            // 
            // VentanaAgregarDueno
            // 
            this.VentanaAgregarDueno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VentanaAgregarDueno.BackColor = System.Drawing.Color.Green;
            this.VentanaAgregarDueno.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentanaAgregarDueno.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.VentanaAgregarDueno.Location = new System.Drawing.Point(355, 221);
            this.VentanaAgregarDueno.Name = "VentanaAgregarDueno";
            this.VentanaAgregarDueno.Size = new System.Drawing.Size(104, 32);
            this.VentanaAgregarDueno.TabIndex = 42;
            this.VentanaAgregarDueno.Text = "Aceptar";
            this.VentanaAgregarDueno.UseVisualStyleBackColor = false;
            this.VentanaAgregarDueno.Click += new System.EventHandler(this.VentanaAgregarDueno_Click);
            // 
            // textBoxTelefonoDueño
            // 
            this.textBoxTelefonoDueño.Location = new System.Drawing.Point(112, 102);
            this.textBoxTelefonoDueño.Name = "textBoxTelefonoDueño";
            this.textBoxTelefonoDueño.Size = new System.Drawing.Size(275, 20);
            this.textBoxTelefonoDueño.TabIndex = 41;
            // 
            // textBoxNombreDueño
            // 
            this.textBoxNombreDueño.Location = new System.Drawing.Point(112, 37);
            this.textBoxNombreDueño.Name = "textBoxNombreDueño";
            this.textBoxNombreDueño.Size = new System.Drawing.Size(275, 20);
            this.textBoxNombreDueño.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre";
            // 
            // ventanaAgregarDueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 265);
            this.Controls.Add(this.textBoxCédulaDueño);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.VentanaAgregarDueno);
            this.Controls.Add(this.textBoxTelefonoDueño);
            this.Controls.Add(this.textBoxNombreDueño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "ventanaAgregarDueño";
            this.Text = "Agregar Dueño";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCédulaDueño;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button VentanaAgregarDueno;
        private System.Windows.Forms.TextBox textBoxTelefonoDueño;
        private System.Windows.Forms.TextBox textBoxNombreDueño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;




    }
}