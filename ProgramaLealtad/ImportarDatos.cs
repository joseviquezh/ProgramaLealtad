using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
