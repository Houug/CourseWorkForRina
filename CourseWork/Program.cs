using System;
using System.Windows.Forms;

namespace CourseWork
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() // Точка входа в программу
        {
            /*
             * Тут все создается автоматически
             */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // Запускает приложение, которое начинается с создания объекта MainForm
        }
    }
}
