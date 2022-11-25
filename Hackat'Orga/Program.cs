using Microsoft.EntityFrameworkCore;
using Hackat_Orga.Models;

namespace Hackat_Orga
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
            bdtproutiere7Context cnx = new bdtproutiere7Context();
            ApplicationConfiguration.Initialize();
            Application.Run(mainForm: new Home());
        }
    }
}