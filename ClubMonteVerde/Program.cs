using ClubMonteVerde.Presenters;
using ClubMonteVerde.Views.Entrada;

namespace ClubMonteVerde
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
            IAccess view = new Access();
            new AccessPresenter(view);
            Application.Run((Form)view);
        }
    }
}