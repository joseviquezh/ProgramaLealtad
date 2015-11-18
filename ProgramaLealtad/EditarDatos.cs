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
            llenarTabla("Select  NombreF as 'Nombre', NumeroF as 'Numero' From Franquicia", dataGridView2);
            llenarTabla("Select NombreSF as 'Nombre', NumeroSF as 'Numero', NombreF as 'Nombre de Franquicia' From SubFranquicia", dataGridView3);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; ++i)
                {
                    string cedula = (string)dataGridView1.Rows[i].Cells[0].Value;
                    Variables.baseDatos.ejecutarConsulta("update Dueno set Nombre = '" + (string)dataGridView1.Rows[i].Cells[1].Value + "', Telefono = '" + (string)dataGridView1.Rows[i].Cells[2].Value + "' where Cedula = '" + cedula + "'");
                }
                MessageBox.Show("Datos Actulizados Correctamente");
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView2.RowCount - 1; ++i)
                {
                    string nombre = (string)dataGridView2.Rows[i].Cells[0].Value;
                    Variables.baseDatos.ejecutarConsulta("update Franquicia set NumeroF = '" + (string)dataGridView2.Rows[i].Cells[1].Value + "' where NombreF = '" + nombre + "'");
                }
                MessageBox.Show("Datos Actulizados Correctamente");
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView3.RowCount - 1; ++i)
                {
                    string nombreSF = (string)dataGridView3.Rows[i].Cells[0].Value;
                    Variables.baseDatos.ejecutarConsulta("update SubFranquicia set Numero = '" + (string)dataGridView3.Rows[i].Cells[1].Value + "', NombreF = '" + (string)dataGridView3.Rows[i].Cells[2].Value + "' where NombreSF = " + nombreSF + "'");
                }
                MessageBox.Show("Datos Actulizados Correctamente");
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView4.RowCount - 1; ++i)
            {
                string nombrer= (string)dataGridView4.Rows[i].Cells[0].Value;
                
                try
                {
                    Variables.baseDatos.ejecutarConsulta("update Restaurante set Telefono = '" + (string)dataGridView4.Rows[i].Cells[1].Value + "', NombreF = '" + (string)dataGridView4.Rows[i].Cells[2].Value + "', NombreSF = '" + (string)dataGridView4.Rows[i].Cells[3].Value + "' where Nombre = '" + nombrer + "'");
                }
                catch (System.InvalidCastException ex)
                {
                    Variables.baseDatos.ejecutarConsulta("update Restaurante set Telefono = '" + (string)dataGridView4.Rows[i].Cells[1].Value + "', NombreF = '" + (string)dataGridView4.Rows[i].Cells[2].Value + "' where Nombre = '" + nombrer + "'");
                }
                
            }

            MessageBox.Show("Datos Actulizados Correctamente");
        }

       
    }
}
