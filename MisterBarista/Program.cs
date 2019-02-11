using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisterBarista
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Startformular festlegen
            Application.Run(new StartForm());

            //Virus programmieren
            //Thread.Sleep(4000);
           
            //MessageBox.Show("Sie haben sich einen Virus eingefangen, haha!");
        }
    }
}
