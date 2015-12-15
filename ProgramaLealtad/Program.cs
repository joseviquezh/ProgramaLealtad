using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaLealtad
{
            
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ventanaPrincipal());
        }
    }

    class Variables{
        public static AccesoBaseDatos baseDatos =  new AccesoBaseDatos();
        public static bool importar = false;
    }
}
