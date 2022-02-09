using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text;

namespace YugiohPriceMonitoring
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
            Thread tokenThread = new Thread(Classes.APICalls.generateToken);
            tokenThread.Start();
            Application.Run(new Form1());
        }
    }
}
