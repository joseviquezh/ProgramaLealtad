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
    public partial class ventanaEditarDatos : Form
    {
        public ventanaEditarDatos()
        {
            InitializeComponent();
            llenarTabla("Select * From Dueno", dataGridView1);
            llenarTabla("Select NumeroF as 'Numero', NombreF as 'Nombre' From Franquicia", dataGridView2);
            llenarTabla("Select NumeroSF as 'Numero', NombreSF as 'Nombre', NombreF as 'Nombre de Franquicia' From SubFranquicia", dataGridView3);
            llenarTabla("Select Nombre, Telefono, NombreF as 'Nombre de Franquicia', NombreSF as 'Nombre de Subfranquicia' From Restaurante", dataGridView4);
        }
        
        private void botonVolver_Click(object sender, EventArgs e)
        {
            ventanaPrincipal vP = new ventanaPrincipal();
            this.Hide();
            vP.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonAgregarDueno_Click(object sender, EventArgs e)
        {
            ventanaAgregarDueño vAD = new ventanaAgregarDueño();
            vAD.ShowDialog();
            llenarTabla("Select * From Dueno", dataGridView1);
        }

        private void botonAgregarFranquicia_Click(object sender, EventArgs e)
        {
            VentanaAgregarFranquicia vAF = new VentanaAgregarFranquicia();
            vAF.ShowDialog();
            llenarTabla("Select NumeroF as 'Numero', NombreF as 'Nombre' From Franquicia", dataGridView2);
        }

        private void botonSubfranqucia_Click(object sender, EventArgs e)
        {
            VentanaAgregarSubfranquicia vAS = new VentanaAgregarSubfranquicia();
            vAS.ShowDialog();
            llenarTabla("Select NumeroSF as 'Numero', NombreSF as 'Nombre', NombreF as 'Nombre de Franquicia' From SubFranquicia", dataGridView3);
        }

        private void botonAgregarRestaurante_Click(object sender, EventArgs e)
        {
            VentanaAgregarRestaurante vAR = new VentanaAgregarRestaurante();
            vAR.ShowDialog();
            llenarTabla("Select Nombre, Telefono, NombreF as 'Nombre de Franquicia', NombreSF as 'Nombre de Subfranquicia' From Restaurante", dataGridView4);
        }

        private	void llenarTabla(String	consulta, DataGridView dataGridView)
        {

            DataTable tabla	= null;
            try
            {
                tabla = Variables.baseDatos.ejecutarConsultaTabla(consulta);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = tabla;
                dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                dataGridView.DataSource = bindingSource;
                for	(int i = 0; i < dataGridView.ColumnCount; i++)
                {
	                dataGridView.Columns[i].Width = 250;
                }
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
