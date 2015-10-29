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
    public partial class VentanaAgregarSubfranquicia : Form
    {
        public VentanaAgregarSubfranquicia()
        {
            InitializeComponent();
            llenarComboBox(this.comboBoxFranquicia);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonAceptarRestaurante_Click_1(object sender, EventArgs e)
        {
            string insercionSQL = "Insert into SubFranquicia";
            insercionSQL += " values('"+this.textBoxNombre.Text+"','" + this.comboBoxFranquicia.Text +  "' , '" + this.textBoxNumero.Text + "')";
            try
            {
                Variables.baseDatos.ejecutarInsercionTabla(insercionSQL);
                MessageBox.Show("Subfranquicia agregada exitosamente");
                this.textBoxNombre.Text = this.textBoxNumero.Text = string.Empty;
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
