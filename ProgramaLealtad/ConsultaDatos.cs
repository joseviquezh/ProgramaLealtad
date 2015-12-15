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

            llenarTabla("select NombreF as 'Nombre de Franquicia', NumeroF as 'Numero de Franquicia' from Franquicia", dataGridView1);
            llenarTabla("select NombreF as 'Nombre de Franquicia', NombreRestaurante as 'Nombre de Restaurante',Telefono, Anno as 'Año', Mes, ClientesQueVuelven as 'Clientes que Vuelven', PorcentajeNuevosClientes as 'Porcentaje de Nuevos Clientes', ClientesQueVuelvenDespuesDeLaPrimeraCompra as 'Clientes que vuelven después de la primera compra', NuveosClientes as 'Nuevos clientes'  from Restaurante join datosDeRestaurante on Nombre = NombreRestaurante", dataGridView2);
        }

        private void llenarTabla(String consulta, DataGridView dataGridView)
        {

            DataTable tabla = null;
            try
            {
                tabla = Variables.baseDatos.ejecutarConsultaTabla(consulta);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = tabla;
                dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                dataGridView.DataSource = bindingSource;
                for (int i = 0; i < dataGridView.ColumnCount; i++)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Franquicia
        {
            dataGridView3.DataSource = null;
            dataGridView3.Refresh();
            comboBox2.Text = comboBox3.Text = comboBox4.Text = string.Empty;
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();

            llenarComboBox("select Nombre from Restaurante where NombreF = '" + (string)comboBox1.SelectedItem + " ' ", this.comboBox2);

            llenarTabla("select NombreF as 'Nombre de Franquicia', NumeroF as 'Numero de Franquicia' from Franquicia where NombreF = '" + (string)comboBox1.SelectedItem + "'", dataGridView1);
            llenarTabla("select NombreRestaurante as 'Nombre de Restaurante',Telefono, Anno as 'Año', Mes, ClientesQueVuelven as 'Clientes que Vuelven', PorcentajeNuevosClientes as 'Porcentaje de Nuevos Clientes', ClientesQueVuelvenDespuesDeLaPrimeraCompra as 'Clientes que vuelven después de la primera compra', NuveosClientes as 'Nuevos clientes'  from Restaurante join datosDeRestaurante on Nombre = NombreRestaurante where NombreF = '" + (string)comboBox1.SelectedItem + "'", dataGridView2);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //Restaurante
        {
            dataGridView3.DataSource = null;
            dataGridView3.Refresh();
            comboBox3.Text = comboBox4.Text = string.Empty;
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            
            llenarComboBox("select Anno from datosDeRestaurante where NombreRestaurante = '" + (string)comboBox2.SelectedItem + " ' group by Anno", this.comboBox3);

            llenarTabla("select NombreRestaurante as 'Nombre de Restaurante',Telefono, Anno as 'Año', Mes, ClientesQueVuelven as 'Clientes que Vuelven', PorcentajeNuevosClientes as 'Porcentaje de Nuevos Clientes', ClientesQueVuelvenDespuesDeLaPrimeraCompra as 'Clientes que vuelven después de la primera compra', NuveosClientes as 'Nuevos clientes'  from Restaurante join datosDeRestaurante on Nombre = NombreRestaurante where Nombre = '" + (string)comboBox2.SelectedItem + "'", dataGridView2);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) //Año
        {
            comboBox4.Text = string.Empty;
            comboBox4.Items.Clear();
            llenarComboBox("select Mes from datosDeRestaurante where NombreRestaurante = '" + (string)comboBox2.SelectedItem + " ' and Anno = " + (int)comboBox3.SelectedItem, this.comboBox4);
            llenarTabla("select NombreRestaurante as 'Nombre de Restaurante',Telefono, Mes, ClientesQueVuelven as 'Clientes que Vuelven', PorcentajeNuevosClientes as 'Porcentaje de Nuevos Clientes', ClientesQueVuelvenDespuesDeLaPrimeraCompra as 'Clientes que vuelven después de la primera compra', NuveosClientes as 'Nuevos clientes'  from Restaurante join datosDeRestaurante on Nombre = NombreRestaurante where Nombre = '" + (string)comboBox2.SelectedItem + "' and Anno = " + (int)comboBox3.SelectedItem, dataGridView2);

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e) //Mes
        {
            llenarTabla("select NombreRestaurante as 'Nombre de Restaurante',Telefono, ClientesQueVuelven as 'Clientes que Vuelven', PorcentajeNuevosClientes as 'Porcentaje de Nuevos Clientes', ClientesQueVuelvenDespuesDeLaPrimeraCompra as 'Clientes que vuelven después de la primera compra', NuveosClientes as 'Nuevos clientes'  from Restaurante join datosDeRestaurante on Nombre = NombreRestaurante where Nombre = '" + (string)comboBox2.SelectedItem + "' and Anno =" + (int)comboBox3.SelectedItem + " and Mes = '" + (string)comboBox4.SelectedItem + "'", dataGridView2);
            llenarTabla("Exec CalculaDerivados " + Convert.ToInt32(comboBox4.SelectedItem ) + "," + Convert.ToInt32(comboBox3.SelectedItem) + ", '" + (string)comboBox2.SelectedItem + "'", dataGridView3);        
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i < dataGridView2.RowCount - 1; ++i)
                {
                    Variables.baseDatos.ejecutarConsulta("update datosDeRestaurante set ClientesQueVuelven = " + Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value) + ", PorcentajeNuevosClientes = " + Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value) + ", ClientesQueVuelvenDespuesDeLaPrimeraCompra = " + Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value) + ", NuveosClientes = " + Convert.ToInt32(dataGridView2.Rows[i].Cells[5].Value) + " where NombreRestaurante = '" + (string)comboBox2.SelectedItem + "' and Anno = " + Convert.ToInt32(comboBox3.SelectedItem) + " and Mes = " + Convert.ToInt32(comboBox4.SelectedItem));
                }

                for (int i = 0; i < dataGridView3.RowCount -1; ++i)
                {
                    Variables.baseDatos.ejecutarConsulta("update Transacciones set Cantidad = " + Convert.ToInt32(dataGridView3.Rows[i].Cells[0].Value) + ", Monto = " + Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value) + " where Nombre = '" + (string)comboBox2.SelectedItem + "' and Ano = " + Convert.ToInt32(comboBox3.SelectedItem) + " and Mes = " + Convert.ToInt32(comboBox4.SelectedItem));
                    Variables.baseDatos.ejecutarConsulta("update TransaccionesDeClientesDeLealtad set CantidadDeTransaccionesClientesDeLealtad = " + Convert.ToInt32(dataGridView3.Rows[i].Cells[2].Value) + ", MontoDeClientesDeLealtad = " + Convert.ToInt32(dataGridView3.Rows[i].Cells[3].Value) + " where Nombre = '" + (string)comboBox2.SelectedItem + "' and Ano = " + Convert.ToInt32(comboBox3.SelectedItem) + " and Mes = " + Convert.ToInt32(comboBox4.SelectedItem));
                    llenarTabla("Exec CalculaDerivados " + Convert.ToInt32(comboBox4.SelectedItem) + "," + Convert.ToInt32(comboBox3.SelectedItem) + ", '" + (string)comboBox2.SelectedItem + "'", dataGridView3);                
                }
                MessageBox.Show("Datos Actualizados Correctamente");
            }
            catch (SqlException ex)
            {
                string mensajeError = ex.ToString();
                MessageBox.Show(mensajeError);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
