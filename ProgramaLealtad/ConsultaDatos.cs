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
    public partial class ventanaConsultarDatos : Form
    {
        public ventanaConsultarDatos()
        {
            InitializeComponent();
            llenarComboBox("select NombreF from Franquicia", this.comboBox1);
            llenarComboBox("select Nombre from Restaurante", this.comboBox2);
            llenarComboBox("select Mes from Transacciones", this.comboBox3);
            llenarComboBox("select Ano from Transacciones", this.comboBox4);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaPrincipal vP = new ventanaPrincipal();
            this.Hide();
            vP.Show();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            ventanaPrincipal vP = new ventanaPrincipal();
            vP.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarReporte gR = new GenerarReporte();
            gR.ShowDialog();
        }

        private void llenarComboBox(string consulta, ComboBox comboBox)
        {
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
