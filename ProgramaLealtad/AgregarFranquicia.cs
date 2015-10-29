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
    public partial class VentanaAgregarFranquicia : Form
    {
        public VentanaAgregarFranquicia()
        {
            InitializeComponent();
            llenarComboBox(comboBoxFranquicia);
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentanaAgregarDueno_Click(object sender, EventArgs e)
        {
            string insercionSQL = "Insert into Franquicia";
            insercionSQL += " values('" + this.textBoxNombreFranquicia.Text + "' , '" + this.textBoxIDFranquicia.Text + "')";
            try
            {
                Variables.baseDatos.ejecutarInsercionTabla(insercionSQL);
                MessageBox.Show("Franquicia agregada exitosamente");
                this.textBoxIDFranquicia.Text = this.textBoxNombreFranquicia.Text = string.Empty;
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
        }

        private void llenarComboBox(ComboBox comboBox)
        {
            string consulta = "select Nombre from Dueno";
            SqlDataReader datos = null;
            try
            {
                datos = Variables.baseDatos.ejecutarConsulta(consulta);
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
            if (datos != null)
            {
                while (datos.Read())
                {
                    comboBox.Items.Add(datos.GetValue(0));
                }
            }
            else
            {
                MessageBox.Show("Datos	vacio");
            }
        }
    }
}
