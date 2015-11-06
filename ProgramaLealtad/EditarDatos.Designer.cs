namespace ProgramaLealtad
{
    partial class ventanaEditarDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaEditarDatos));
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabDueno = new System.Windows.Forms.TabPage();
            this.botonAgregarDueno = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabFranquicia = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.botonAgregarFranquicia = new System.Windows.Forms.Button();
            this.tabSubfranquicia = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.botonSubfranqucia = new System.Windows.Forms.Button();
            this.tabRestaurante = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.botonAgregarRestaurante = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.tabGeneral.SuspendLayout();
            this.tabDueno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabFranquicia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabSubfranquicia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabRestaurante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabDueno);
            this.tabGeneral.Controls.Add(this.tabFranquicia);
            this.tabGeneral.Controls.Add(this.tabSubfranquicia);
            this.tabGeneral.Controls.Add(this.tabRestaurante);
            this.tabGeneral.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGeneral.ItemSize = new System.Drawing.Size(58, 23);
            this.tabGeneral.Location = new System.Drawing.Point(23, 31);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(846, 598);
            this.tabGeneral.TabIndex = 0;
            // 
            // tabDueno
            // 
            this.tabDueno.Controls.Add(this.botonAgregarDueno);
            this.tabDueno.Controls.Add(this.dataGridView1);
            this.tabDueno.Location = new System.Drawing.Point(4, 27);
            this.tabDueno.Name = "tabDueno";
            this.tabDueno.Padding = new System.Windows.Forms.Padding(3);
            this.tabDueno.Size = new System.Drawing.Size(838, 567);
            this.tabDueno.TabIndex = 0;
            this.tabDueno.Text = "Dueño";
            this.tabDueno.UseVisualStyleBackColor = true;
            // 
            // botonAgregarDueno
            // 
            this.botonAgregarDueno.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonAgregarDueno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonAgregarDueno.Location = new System.Drawing.Point(698, 6);
            this.botonAgregarDueno.Name = "botonAgregarDueno";
            this.botonAgregarDueno.Size = new System.Drawing.Size(134, 32);
            this.botonAgregarDueno.TabIndex = 1;
            this.botonAgregarDueno.Text = "Agregar Dueño";
            this.botonAgregarDueno.UseVisualStyleBackColor = false;
            this.botonAgregarDueno.Click += new System.EventHandler(this.botonAgregarDueno_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(826, 509);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabFranquicia
            // 
            this.tabFranquicia.Controls.Add(this.dataGridView2);
            this.tabFranquicia.Controls.Add(this.botonAgregarFranquicia);
            this.tabFranquicia.Location = new System.Drawing.Point(4, 27);
            this.tabFranquicia.Name = "tabFranquicia";
            this.tabFranquicia.Padding = new System.Windows.Forms.Padding(3);
            this.tabFranquicia.Size = new System.Drawing.Size(838, 567);
            this.tabFranquicia.TabIndex = 1;
            this.tabFranquicia.Text = "Franquicia";
            this.tabFranquicia.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(826, 509);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // botonAgregarFranquicia
            // 
            this.botonAgregarFranquicia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonAgregarFranquicia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonAgregarFranquicia.Location = new System.Drawing.Point(677, 6);
            this.botonAgregarFranquicia.Name = "botonAgregarFranquicia";
            this.botonAgregarFranquicia.Size = new System.Drawing.Size(155, 32);
            this.botonAgregarFranquicia.TabIndex = 2;
            this.botonAgregarFranquicia.Text = "Agregar Franquicia";
            this.botonAgregarFranquicia.UseVisualStyleBackColor = false;
            this.botonAgregarFranquicia.Click += new System.EventHandler(this.botonAgregarFranquicia_Click);
            // 
            // tabSubfranquicia
            // 
            this.tabSubfranquicia.Controls.Add(this.dataGridView3);
            this.tabSubfranquicia.Controls.Add(this.botonSubfranqucia);
            this.tabSubfranquicia.Location = new System.Drawing.Point(4, 27);
            this.tabSubfranquicia.Name = "tabSubfranquicia";
            this.tabSubfranquicia.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubfranquicia.Size = new System.Drawing.Size(838, 567);
            this.tabSubfranquicia.TabIndex = 2;
            this.tabSubfranquicia.Text = "Subfranquicia";
            this.tabSubfranquicia.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 44);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(826, 509);
            this.dataGridView3.TabIndex = 4;
            // 
            // botonSubfranqucia
            // 
            this.botonSubfranqucia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonSubfranqucia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSubfranqucia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonSubfranqucia.Location = new System.Drawing.Point(654, 6);
            this.botonSubfranqucia.Name = "botonSubfranqucia";
            this.botonSubfranqucia.Size = new System.Drawing.Size(178, 32);
            this.botonSubfranqucia.TabIndex = 3;
            this.botonSubfranqucia.Text = "Agregar Subfranquicia";
            this.botonSubfranqucia.UseVisualStyleBackColor = false;
            this.botonSubfranqucia.Click += new System.EventHandler(this.botonSubfranqucia_Click);
            // 
            // tabRestaurante
            // 
            this.tabRestaurante.Controls.Add(this.dataGridView4);
            this.tabRestaurante.Controls.Add(this.botonAgregarRestaurante);
            this.tabRestaurante.Location = new System.Drawing.Point(4, 27);
            this.tabRestaurante.Name = "tabRestaurante";
            this.tabRestaurante.Padding = new System.Windows.Forms.Padding(3);
            this.tabRestaurante.Size = new System.Drawing.Size(838, 567);
            this.tabRestaurante.TabIndex = 3;
            this.tabRestaurante.Text = "Restaurante";
            this.tabRestaurante.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 44);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(826, 509);
            this.dataGridView4.TabIndex = 5;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // botonAgregarRestaurante
            // 
            this.botonAgregarRestaurante.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonAgregarRestaurante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregarRestaurante.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonAgregarRestaurante.Location = new System.Drawing.Point(654, 6);
            this.botonAgregarRestaurante.Name = "botonAgregarRestaurante";
            this.botonAgregarRestaurante.Size = new System.Drawing.Size(178, 32);
            this.botonAgregarRestaurante.TabIndex = 4;
            this.botonAgregarRestaurante.Text = "Agregar Restaurante";
            this.botonAgregarRestaurante.UseVisualStyleBackColor = false;
            this.botonAgregarRestaurante.Click += new System.EventHandler(this.botonAgregarRestaurante_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.botonVolver.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.ForeColor = System.Drawing.Color.Black;
            this.botonVolver.Location = new System.Drawing.Point(12, 635);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(134, 32);
            this.botonVolver.TabIndex = 2;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // ventanaEditarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 674);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.tabGeneral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ventanaEditarDatos";
            this.Text = "Edición de Datos";
            this.tabGeneral.ResumeLayout(false);
            this.tabDueno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabFranquicia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabSubfranquicia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabRestaurante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabDueno;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabFranquicia;
        private System.Windows.Forms.TabPage tabSubfranquicia;
        private System.Windows.Forms.TabPage tabRestaurante;
        private System.Windows.Forms.Button botonAgregarDueno;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonAgregarFranquicia;
        private System.Windows.Forms.Button botonSubfranqucia;
        private System.Windows.Forms.Button botonAgregarRestaurante;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.DataGridView dataGridView4;
    }
}