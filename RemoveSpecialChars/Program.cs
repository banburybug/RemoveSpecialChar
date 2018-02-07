using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RemoveSpecialChars
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

           // string fileName = "";
            //fileName = System.IO.File.ReadAllText(@"C:\Users\matthew.smith\Desktop\Mobile Ticket Enhancment\Fueling_TX.json");
            //string text = System.IO.File.ReadAllText(@"C:\Users\matthew.smith\Desktop\Fueling_TX.json");

            Application.Run(new Form1());


        }
    }
}
