using CSharp.Forms.Data;
using CSharp.Repository.Interfaces;
using CSharp.Repository.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace CSharp.MainApp
{

    /*
     * This demostrats 3 things:
     *    1)  Generating the service using the GetService, this can be used for the initial 
     *    form load and for user controls
     *    2) Using the CreateForm. This creates a form where the service is injected into
     *    the initialiaser. This can be used for all forms that are in other libraries.
     *    3) Automatically retrieving all forms within a solution and configuring them for DI
    */

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

            var builder = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var configuration = builder.Build();

            var services = new ServiceCollection();
            // find all forms in the solution and add them to the ServiceCollection
            var forms = GetAllForms();
            forms?.ForEach(x => services.AddTransient(x));

            services
                .AddSingleton<IConfiguration>(configuration)
                .AddDbContext<DataContext>(options => options.UseInMemoryDatabase(configuration.GetConnectionString("WinformsDatabase")))
                .AddSingleton<IFormFactory, FormFactory>()
                .AddScoped<IHelloWorkRepository, HelloWorkRepository>()
                .AddScoped<IUsersRepository, UsersRepository>()
                .AddLogging(configure => configure.AddConsole());

            // Create the DI container
            var serviceProvider = services.BuildServiceProvider();
            ServiceLocator.SetServiceProvider(serviceProvider);

            ApplicationConfiguration.Initialize();

            var mainForm = serviceProvider.GetRequiredService<MainForm>();
            Application.Run(mainForm);


        }

        private static List<Type> GetAllForms()
        {
            var solutionDir = Path.GetDirectoryName(Application.StartupPath);

            if (solutionDir is null)
                return new List<Type>();

            var assemblyFiles = Directory.GetFiles(solutionDir, "*.dll", SearchOption.AllDirectories);

            var forms = assemblyFiles
                .Select(Assembly.LoadFrom)
                .SelectMany(a => a.GetTypes())
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(Form)))
                .ToList();

            return forms;
        }

    }
}