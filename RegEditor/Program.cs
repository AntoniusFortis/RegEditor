namespace RegEditor
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Security.Principal;
    using System.Windows.Forms;
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            var pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);

            //if (hasAdministrativeRight)
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var mutex = new System.Threading.Mutex(true, Application.ProductName, out var onlyInstance);

                if (onlyInstance)
                    Application.Run(new MainForm());
                else
                    MessageBox.Show(@"Приложение уже запущено!", Application.ProductName, MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
            //}
            //else
            //{
            //    var processInfo = new ProcessStartInfo
            //    {
            //        Verb = "runas",
            //        FileName = Application.ExecutablePath
            //    };
            //    try
            //    {
            //        Process.Start(processInfo); //пытаемся запустить процесс
            //    }
            //    catch (Win32Exception)
            //    {
            //    }

            //    Application.Exit(); //закрываем текущую копию программы (даже если пользователь отменил запуск с правами администратора в окне UAC)
            //}
        }
    }
}
