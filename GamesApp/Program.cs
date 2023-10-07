using System;
using System.Windows.Forms;

namespace GamesApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth());
        }
        public static string loginUser;
        public static string PasswordUser;
        public static ushort scoreBest;
    }
}
