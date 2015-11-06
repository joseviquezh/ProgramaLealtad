namespace ProgramaLealtad
{
    partial class ventanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaPrincipal));
            this.botonImportar = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonConsulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.botonSalirPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonImportar
            // 
            this.botonImportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonImportar.AutoSize = true;
            this.botonImportar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonImportar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonImportar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonImportar.Location = new System.Drawing.Point(222, 92);
            this.botonImportar.Name = "botonImportar";
            this.botonImportar.Size = new System.Drawing.Size(289, 72);
            this.botonImportar.TabIndex = 0;
            this.botonImportar.Text = "Importar Datos";
            this.botonImportar.UseVisualStyleBackColor = false;
            this.botonImportar.Click += new System.EventHandler(this.botonImportar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonEditar.AutoSize = true;
            this.botonEditar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonEditar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonEditar.Location = new System.Drawing.Point(222, 323);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(289, 72);
            this.botonEditar.TabIndex = 1;
            this.botonEditar.Text = "Editar Información General";
            this.botonEditar.UseVisualStyleBackColor = false;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonConsulta
            // 
            this.botonConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonConsulta.AutoSize = true;
            this.botonConsulta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonConsulta.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConsulta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonConsulta.Location = new System.Drawing.Point(222, 203);
            this.botonConsulta.Name = "botonConsulta";
            this.botonConsulta.Size = new System.Drawing.Size(289, 75);
            this.botonConsulta.TabIndex = 2;
            this.botonConsulta.Text = "Consulta de Datos";
            this.botonConsulta.UseVisualStyleBackColor = false;
            this.botonConsulta.Click += new System.EventHandler(this.botonConsulta_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenido al Programa de Lealtad";
            // 
            // botonSalirPrincipal
            // 
            this.botonSalirPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonSalirPrincipal.AutoSize = true;
            this.botonSalirPrincipal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.botonSalirPrincipal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalirPrincipal.ForeColor = System.Drawing.Color.Black;
            this.botonSalirPrincipal.Location = new System.Drawing.Point(12, 425);
            this.botonSalirPrincipal.Name = "botonSalirPrincipal";
            this.botonSalirPrincipal.Size = new System.Drawing.Size(127, 35);
            this.botonSalirPrincipal.TabIndex = 4;
            this.botonSalirPrincipal.Text = "Salir";
            this.botonSalirPrincipal.UseVisualStyleBackColor = false;
            this.botonSalirPrincipal.Click += new System.EventHandler(this.botonSalirPrincipal_Click);
            // 
            // ventanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(734, 472);
            this.Controls.Add(this.botonSalirPrincipal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonConsulta);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.botonImportar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ventanaPrincipal";
            this.Text = "Programa de Lealtad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonImportar;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonSalirPrincipal;

    }
}

