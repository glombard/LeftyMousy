using System;
using System.Windows.Forms;

namespace LeftyMousy
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var icon = new MouseIcon())
            {
                icon.Show();
                Application.Run();
            }
        }
    }
}