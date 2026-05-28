using System;
using System.Windows.Forms;

namespace MzansiTechPayroll
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable visual styles for the application
            Application.EnableVisualStyles();

            // Set compatible text rendering (default)
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the main form (this starts your payroll application)
            Application.Run(new MainForm());
        }
    }
}