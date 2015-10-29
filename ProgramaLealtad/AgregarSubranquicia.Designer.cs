namespace ProgramaLealtad
{
    partial class VentanaAgregarSubfranquicia
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
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFranquicia = new System.Windows.Forms.ComboBox();
            this.botonAceptarRestaurante = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(120, 150);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(275, 20);
            this.textBoxNumero.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numero";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "¿De qué franquicia?";
            // 
            // comboBoxFranquicia
            // 
            this.comboBoxFranquicia.FormattingEnabled = true;
            this.comboBoxFranquicia.Location = new System.Drawing.Point(34, 69);
            this.comboBoxFranquicia.Name = "comboBoxFranquicia";
            this.comboBoxFranquicia.Size = new System.Drawing.Size(361, 21);
            this.comboBoxFranquicia.TabIndex = 10;
            // 
            // botonAceptarRestaurante
            // 
            this.botonAceptarRestaurante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAceptarRestaurante.BackColor = System.Drawing.Color.Green;
            this.botonAceptarRestaurante.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptarRestaurante.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.botonAceptarRestaurante.Location = new System.Drawing.Point(355, 201);
            this.botonAceptarRestaurante.Name = "botonAceptarRestaurante";
            this.botonAceptarRestaurante.Size = new System.Drawing.Size(104, 32);
            this.botonAceptarRestaurante.TabIndex = 20;
            this.botonAceptarRestaurante.Text = "Aceptar";
            this.botonAceptarRestaurante.UseVisualStyleBackColor = false;
            this.botonAceptarRestaurante.Click += new System.EventHandler(this.botonAceptarRestaurante_Click_1);
            // 
            // Cancelar
            // 
            this.Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancelar.BackColor = System.Drawing.Color.Crimson;
            this.Cancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Cancelar.Location = new System.Drawing.Point(12, 202);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(104, 32);
            this.Cancelar.TabIndex = 28;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(120, 109);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(275, 20);
            this.textBoxNombre.TabIndex = 30;
            // 
            // VentanaAgregarSubfranquicia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 245);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.botonAceptarRestaurante);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFranquicia);
            this.MaximizeBox = false;
            this.Name = "VentanaAgregarSubfranquicia";
            this.Text = "Agregar Subfranquicia";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFranquicia;
        private System.Windows.Forms.Button botonAceptarRestaurante;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;

    }
}