using CSharp.Forms.Data;
using CSharp.Repository.Interfaces;
using CSharp.Repository.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Configuration;
using System.Reflection;

namespace CSharp.MainApp
{

    /*
     * This demostrats 3 things:
     *    1)  Generating the service using the GetProviderService, this can be used for the initial 
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

        #region Forms
        private static List<Type> GetAllForms()
        {
            var solutionDir = Path.GetDirectoryName(Application.StartupPath);
            var assemblyFiles = Directory.GetFiles(solutionDir, "*.dll", SearchOption.AllDirectories);

            var forms = assemblyFiles
                .Select(Assembly.LoadFrom)
                .SelectMany(a => a.GetTypes())
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(Form)))
                .ToList();

            return forms;
        }
        ///// <summary>
        ///// Gets a list of all forms that are used by the solution, including those within other projects 
        ///// that are referenced. They then used to set up dependency injection
        ///// </summary>
        //private static List<Type> GetAllForms()
        //{
        //    // Get a list of all the forms in the solution
        //    var forms = new List<Type>();

        //    // Add the forms from the current assembly
        //    forms.AddRange(GetFormTypes(Assembly.GetExecutingAssembly()));

        //    // Add forms from all the referenced assemblies that belong to the solution
        //    foreach (var assemblyName in Assembly.GetExecutingAssembly().GetReferencedAssemblies())
        //    {
        //        // Load the referenced assembly
        //        var _assembly = Assembly.Load(assemblyName);
        //        // Check if the assembly belongs to the solution
        //        if (IsAssemblyInSolution(_assembly))
        //        {
        //            // Add the forms from the assembly
        //            forms.AddRange(GetFormTypes(_assembly));
        //        }
        //    }
        //    return forms;
        //}

        //// Returns true if the assembly belongs to the solution
        //private static bool IsAssemblyInSolution(Assembly assembly)
        //{
        //    // Get the solution directory
        //    var solutionDir = Path.GetDirectoryName(Application.StartupPath);
        //    // Get the assembly directory
        //    string assemblyDir = Path.GetDirectoryName(assembly.Location);
        //    // Check if the assembly directory is a subdirectory of the solution directory
        //    return assemblyDir.StartsWith(solutionDir, StringComparison.OrdinalIgnoreCase);
        //}

        //// Returns a list of all the form types in the assembly
        //private static List<Type> GetFormTypes(Assembly assembly)
        //{
        //    return assembly.GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(Form))).ToList();
        //}
        #endregion

    }
}