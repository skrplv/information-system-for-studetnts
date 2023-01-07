using System;
using System.Windows.Forms;

namespace Messager
{
    static class Program
    {
        public static LoginForm logForm;
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Открытие стартовой страницы авторизации
            Application.Run(logForm = new LoginForm());    
        }
    }  
}
