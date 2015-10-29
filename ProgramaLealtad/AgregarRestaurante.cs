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
    public partial class VentanaAgregarRestaurante : Form
    {
        public VentanaAgregarRestaurante()
        {
            InitializeComponent();
            llenarComboBox(this.comboBoxRestaurante);
        }

        private void botonAceptarRestaurante_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonAceptarRestaurante_Click_1(object sender, EventArgs e)
        {
            string insercionSQL = "Insert into Restaurante(Nombre,Telefono,NombreF)";
            insercionSQL += " values('" + this.textBoxNombreRestaurante.Text + "','" + this.textBoxTelefonoRestaurante.Text + "','" + this.comboBoxRestaurante.Text + "')";
            try
            {
                Variables.baseDatos.ejecutarInsercionTabla(insercionSQL);
                MessageBox.Show("Restaurante agregado exitosamente");
                this.textBoxNombreRestaurante.Text = this.textBoxTelefonoRestaurante.Text = string.Empty;
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
        }

        private void llenarComboBox(ComboBox comboBox)
        {
            string consulta = "select NombreF from Franquicia";
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
