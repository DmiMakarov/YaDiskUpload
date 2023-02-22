using System;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;

namespace YaDiskUpload
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!IsRunningAsAdmin())
            {
                //Настройка информации о новом процессе нашего приложения
                ProcessStartInfo processStartInfo = new ProcessStartInfo(Assembly.GetEntryAssembly().CodeBase);
                //Настройка ProcessStartInfo. Ключевое слово «runas» позволит запустить процесс от имени администратора
                processStartInfo.UseShellExecute = true;
                processStartInfo.Verb = "runas";
                //Запуск нового процесса нашего приложения
                try
                {
                    Process.Start(processStartInfo);
                }
                catch
                {
                    Application.Exit();
                };
                //Остановка старого процесса
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
        static bool IsRunningAsAdmin()
        {
            //Получим пользователя
            WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();
            //Получим роль
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(windowsIdentity);
            //Вернём ТРУ, если приложение имеет права администратора
            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
