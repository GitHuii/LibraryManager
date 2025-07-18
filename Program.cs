using LibraryManager.DAO;
using LibraryManager.View;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager
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
            
            DbContextProvider.Initialize();
            Application.Run(new LoginForm());
        }
    }
}