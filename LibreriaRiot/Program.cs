using LibreriaRiot.Principal;
using LibreriaRiot.Principal.lobi;

namespace LibreriaRiot
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LobiPrincipal fLobi = new LobiPrincipal();
            Login login = new Login(fLobi);
            login.Show();
            Application.Run();
        }
    }
}