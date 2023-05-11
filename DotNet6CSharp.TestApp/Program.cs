using DotNet6CSharp.Repository;

namespace DotNet6CSharp.TestApp
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
            ServiceConfiguration.ConfigureServices();
            Application.Run(new MainForm());
        }
    }
}