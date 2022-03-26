using System;
using System.Windows.Forms;
using System.Drawing;
namespace Main_Form
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Forms());
        }
    }
}
