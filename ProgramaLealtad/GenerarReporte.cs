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
    public partial class GenerarReporte : Form
    {
        public GenerarReporte()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exportar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SaveFileDialog sFD = new SaveFileDialog();

        private void buttonUbicarInforme_Click(object sender, EventArgs e)
        {
            sFD.Filter = "Archivos .csv|*.csv";
            sFD.Title = "Seleccione el informe a importar";
            sFD.ShowDialog();

            if (sFD.FileName != string.Empty)
            {
                this.textBox1.Text = sFD.FileName;
            }
        }
    }
}
