namespace CSharp.Repository
{
    using CSharp.Repository.Interfaces;
    using CSharp.Repository.Services;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// A module containing the <see cref="ServiceCollection"/> used for dependency injection, throughout the application
    /// </summary>
    public static partial class ServiceConfiguration
    {

        private static IServiceProvider? ServiceProvider { get; set; }

        /// <summary>
        /// Adds the scoped services into the <see cref="ServiceCollection"/>
        /// </summary>
        /// <param name="forms"></param>
        public static void ConfigureServices(List<Type> forms)
        {
            var services = new ServiceCollection();
            forms?.ForEach(x => services.AddTransient(x));

            services.AddScoped<IHelloWorkRepository, HelloWorkRepository>();
            ServiceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        /// Returns a new instance of the scoped service associated with type <typeparamref name="T"/>
        /// </summary>
        public static T GetProviderService<T>() where T : class
        {
            if (ServiceProvider == null) return null;
            return (T)ServiceProvider.GetService(typeof(T));
        }

        /// <summary>
        /// Creates an instance of the form
        /// </summary>
        public static T CreateForm<T>() where T : Form
        {
            if (ServiceProvider == null) return null;
            return (T)ServiceProvider.GetService(typeof(T));
        }

    }
}