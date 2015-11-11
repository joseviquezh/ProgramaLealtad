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

            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "C:\\Users\\luis diego\\Desktop\\Bases I\\BD.xlsx" + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";"))

            using (OleDbCommand command = new OleDbCommand("Select * from [Sheet1$] ", connection))

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                adapter.Fill(ds);
            }


            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                MessageBox.Show(ds.Tables[0].Rows[i].ItemArray[i].ToString());
            }

            this.Close();
        }

        OpenFileDialog oFD = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            oFD.Filter = "Archivos .csv|*.csv";
            oFD.Title = "Seleccione el informe a importar";

            if (oFD.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = oFD.SafeFileName;
            }

        }
        
        private void ventanaImportarDatos_Load(object sender, EventArgs e)
        {

        }
      
    }
}
