namespace ProgramaLealtad
{
    partial class VentanaAgregarRestaurante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAgregarRestaurante));
            this.comboBoxRestaurante = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombreRestaurante = new System.Windows.Forms.TextBox();
            this.textBoxTelefonoRestaurante = new System.Windows.Forms.TextBox();
            this.botonAceptarRestaurante = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxRestaurante
            // 
            this.comboBoxRestaurante.FormattingEnabled = true;
            this.comboBoxRestaurante.Location = new System.Drawing.Point(38, 67);
            this.comboBoxRestaurante.Name = "comboBoxRestaurante";
            this.comboBoxRestaurante.Size = new System.Drawing.Size(361, 21);
            this.comboBoxRestaurante.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿De qué franquicia?";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teléfono";
            // 
            // textBoxNombreRestaurante
            // 
            this.textBoxNombreRestaurante.Location = new System.Drawing.Point(114, 124);
            this.textBoxNombreRestaurante.Name = "textBoxNombreRestaurante";
            this.textBoxNombreRestaurante.Size = new System.Drawing.Size(275, 20);
            this.textBoxNombreRestaurante.TabIndex = 5;
            // 
            // textBoxTelefonoRestaurante
            // 
            this.textBoxTelefonoRestaurante.Location = new System.Drawing.Point(114, 189);
            this.textBoxTelefonoRestaurante.Name = "textBoxTelefonoRestaurante";
            this.textBoxTelefonoRestaurante.Size = new System.Drawing.Size(275, 20);
            this.textBoxTelefonoRestaurante.TabIndex = 6;
            // 
            // botonAceptarRestaurante
            // 
            this.botonAceptarRestaurante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAceptarRestaurante.BackColor = System.Drawing.Color.Green;
            this.botonAceptarRestaurante.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptarRestaurante.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.botonAceptarRestaurante.Location = new System.Drawing.Point(355, 256);
            this.botonAceptarRestaurante.Name = "botonAceptarRestaurante";
            this.botonAceptarRestaurante.Size = new System.Drawing.Size(104, 32);
            this.botonAceptarRestaurante.TabIndex = 19;
            this.botonAceptarRestaurante.Text = "Aceptar";
            this.botonAceptarRestaurante.UseVisualStyleBackColor = false;
            this.botonAceptarRestaurante.Click += new System.EventHandler(this.botonAceptarRestaurante_Click_1);
            // 
            // Cancelar
            // 
            this.Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancelar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Cancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.Black;
            this.Cancelar.Location = new System.Drawing.Point(12, 257);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(104, 32);
            this.Cancelar.TabIndex = 28;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // VentanaAgregarRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 300);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.botonAceptarRestaurante);
            this.Controls.Add(this.textBoxTelefonoRestaurante);
            this.Controls.Add(this.textBoxNombreRestaurante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRestaurante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "VentanaAgregarRestaurante";
            this.Text = "Agregar Restaurante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRestaurante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombreRestaurante;
        private System.Windows.Forms.TextBox textBoxTelefonoRestaurante;
        private System.Windows.Forms.Button botonAceptarRestaurante;
        private System.Windows.Forms.Button Cancelar;
    }
}