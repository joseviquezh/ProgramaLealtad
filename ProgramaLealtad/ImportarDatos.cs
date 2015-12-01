using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace ProgramaLealtad
{
    public partial class ventanaImportarDatos : Form
    {
        string direccion;

        public ventanaImportarDatos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();

            // using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\luis diego\\Desktop\\Bases I\\BD.xlsx;Extended Properties=\Excel 12.0"/* Xml; HDR = YES; IMEX = 1; TypeGuessRows = 0; ImportMixedTypes = Text*/))
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + direccion + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";"))


            using (OleDbCommand command = new OleDbCommand("Select * from [BD$] ", connection))

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                adapter.Fill(ds);
            }



            double d = double.Parse( ds.Tables[0].Rows[67].ItemArray[1].ToString() );
            DateTime conv = DateTime.FromOADate(d);
            string fecha = conv.ToString();
            
            string mes = "";
            string año = "";
            int slash = 0;
            bool espacio = false;
            int i = 0;
            while( !espacio ){
                if (fecha[i] != '/')
                {
                    if (slash == 0)
                    {
                        mes += fecha[i];
                    }
                    else if(slash == 2)
                    {
                        año += fecha[i];
                    }
                }
                else
                {
                    ++slash;
                }
                if (fecha[i] == ' ')
                {
                    espacio = true;
                }
                ++i;
            }
           
            for ( i = 1; i <= ds.Tables[0].Rows.Count - 3; i++)
            {
                string nombre = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                if (!nombre.Equals("franquicia 1", StringComparison.Ordinal) && !nombre.Equals("franquicia 2.1", StringComparison.Ordinal) && !nombre.Equals("franquicia 2.2", StringComparison.Ordinal) && !nombre.Equals("franquicia 2.3", StringComparison.Ordinal) && !nombre.Equals("franquicia 3", StringComparison.Ordinal) && !nombre.Equals("franquicia 4", StringComparison.Ordinal) )
                {
                    //MessageBox.Show(nombre);
                    Variables.baseDatos.ejecutarConsulta("Insert into datosDeRestaurante(NombreRestaurante,Anno,Mes,NuveosClientes,PorcentajeNuevosClientes,ClientesQueVuelven,ClientesQueVuelvenDespuesDeLaPrimeraCompra) values('" + nombre + "'," + año + ",'" + mes + "'," + ds.Tables[0].Rows[i].ItemArray[6] + "," + ds.Tables[0].Rows[i].ItemArray[7] + "," + ds.Tables[0].Rows[i].ItemArray[8] + "," + ds.Tables[0].Rows[i].ItemArray[9] + ");");
                    Variables.baseDatos.ejecutarConsulta("Insert into Transacciones(Nombre,Ano,Mes,Cantidad,Monto) values('" + nombre + "'," + año + ",'" + mes + "'," + ds.Tables[0].Rows[i].ItemArray[1] + "," + ds.Tables[0].Rows[i].ItemArray[2] + ");");
                    Variables.baseDatos.ejecutarConsulta("Insert into TransaccionesDeClientesDeLealtad(Nombre,Ano,Mes,CantidadDeTransaccionesClientesDeLealtad,MontoDeClientesDeLealtad) values('" + nombre + "'," + año + ",'" + mes + "'," + ds.Tables[0].Rows[i].ItemArray[3] + "," + ds.Tables[0].Rows[i].ItemArray[4] + ");");
                }
            }

            this.Close();
        }

        OpenFileDialog oFD = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            oFD.Filter = "Archivos de Excel|*.xlsx";
            oFD.Title = "Seleccione el informe a importar";

            if (oFD.ShowDialog() == DialogResult.OK)
            {
                direccion = this.textBox1.Text = oFD.FileName;
            }

        }
        
        private void ventanaImportarDatos_Load(object sender, EventArgs e)
        {
            
        }
      
    }
}
