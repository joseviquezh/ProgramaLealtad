using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

namespace ProgramaLealtad
{
    public partial class ventanaAgregarDueño : Form
    {
        public ventanaAgregarDueño()
        {
            InitializeComponent();
        }

        private void Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentanaAgregarDueno_Click(object sender, EventArgs e)
        {
            string insercionSQL = "Insert into Dueno";
            insercionSQL += " values('" + this.textBoxCédulaDueño.Text + "', '" + this.textBoxNombreDueño.Text + "',  '" + this.textBoxTelefonoDueño.Text + "')";
            try
            {
                Variables.baseDatos.ejecutarInsercionTabla(insercionSQL);
                MessageBox.Show("Dueño agregado exitosamente");
                this.textBoxCédulaDueño.Text = this.textBoxNombreDueño.Text = this.textBoxTelefonoDueño.Text = string.Empty;
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
        }
    }
}
