namespace ProgramaLealtad
{
    partial class VentanaAgregarFranquicia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAgregarFranquicia));
            this.Cancelar = new System.Windows.Forms.Button();
            this.VentanaAgregarDueno = new System.Windows.Forms.Button();
            this.textBoxIDFranquicia = new System.Windows.Forms.TextBox();
            this.textBoxNombreFranquicia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFranquicia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancelar
            // 
            this.Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancelar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Cancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.Black;
            this.Cancelar.Location = new System.Drawing.Point(13, 239);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(104, 32);
            this.Cancelar.TabIndex = 35;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // VentanaAgregarDueno
            // 
            this.VentanaAgregarDueno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VentanaAgregarDueno.BackColor = System.Drawing.Color.Green;
            this.VentanaAgregarDueno.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentanaAgregarDueno.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.VentanaAgregarDueno.Location = new System.Drawing.Point(356, 238);
            this.VentanaAgregarDueno.Name = "VentanaAgregarDueno";
            this.VentanaAgregarDueno.Size = new System.Drawing.Size(104, 32);
            this.VentanaAgregarDueno.TabIndex = 34;
            this.VentanaAgregarDueno.Text = "Aceptar";
            this.VentanaAgregarDueno.UseVisualStyleBackColor = false;
            this.VentanaAgregarDueno.Click += new System.EventHandler(this.VentanaAgregarDueno_Click);
            // 
            // textBoxIDFranquicia
            // 
            this.textBoxIDFranquicia.Location = new System.Drawing.Point(112, 183);
            this.textBoxIDFranquicia.Name = "textBoxIDFranquicia";
            this.textBoxIDFranquicia.Size = new System.Drawing.Size(275, 20);
            this.textBoxIDFranquicia.TabIndex = 33;
            // 
            // textBoxNombreFranquicia
            // 
            this.textBoxNombreFranquicia.Location = new System.Drawing.Point(112, 118);
            this.textBoxNombreFranquicia.Name = "textBoxNombreFranquicia";
            this.textBoxNombreFranquicia.Size = new System.Drawing.Size(275, 20);
            this.textBoxNombreFranquicia.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre";
            // 
            // comboBoxFranquicia
            // 
            this.comboBoxFranquicia.FormattingEnabled = true;
            this.comboBoxFranquicia.Location = new System.Drawing.Point(42, 62);
            this.comboBoxFranquicia.Name = "comboBoxFranquicia";
            this.comboBoxFranquicia.Size = new System.Drawing.Size(361, 21);
            this.comboBoxFranquicia.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "¿De qué dueño?";
            // 
            // VentanaAgregarFranquicia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 292);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.VentanaAgregarDueno);
            this.Controls.Add(this.textBoxIDFranquicia);
            this.Controls.Add(this.textBoxNombreFranquicia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFranquicia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaAgregarFranquicia";
            this.Text = "Agregar Franquicia";
            this.Load += new System.EventHandler(this.VentanaAgregarFranquicia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button VentanaAgregarDueno;
        private System.Windows.Forms.TextBox textBoxIDFranquicia;
        private System.Windows.Forms.TextBox textBoxNombreFranquicia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFranquicia;
        private System.Windows.Forms.Label label1;
    }
}