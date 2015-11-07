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
    public partial class ventanaPrincipal : Form
    {
        public ventanaPrincipal()
        {
            InitializeComponent();
        }

        private void botonSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonConsulta_Click(object sender, EventArgs e)
        {
            ventanaConsultarDatos vED = new ventanaConsultarDatos();
            this.Hide();
            vED.Show();
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            ventanaEditarDatos vED= new ventanaEditarDatos();
            this.Hide();
            vED.Show();
        }

        private void botonImportar_Click(object sender, EventArgs e)
        {
            ventanaImportarDatos vID = new ventanaImportarDatos();
            vID.ShowDialog();
            
        }

    }
}
