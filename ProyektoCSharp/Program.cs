/*
 * Kent Perocha - 101266723
 * Mark Romel Trespeces - 101258258
 * Young Pyung Yoo – 101254379
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyektoCSharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EventCoordinator eCoord = new EventCoordinator(200, 1000, 100, 5000, 300, 10000);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProjectMenu(eCoord));
        }
    }
}
