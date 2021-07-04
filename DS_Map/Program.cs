using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSPRE
{
    static class Program
    {
        /// <summary>
        /// It: Punto di ingresso principale dell'applicazione.
        /// En: Main entry point of the application. 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainProgram());
        }
    }
}