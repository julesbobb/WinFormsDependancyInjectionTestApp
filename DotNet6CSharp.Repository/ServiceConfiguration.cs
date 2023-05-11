namespace DotNet6CSharp.Repository
{
    using DotNet6CSharp.Repository.Interfaces;
    using DotNet6CSharp.Repository.Services;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    /// <summary>
    /// A module containing the <see cref="ServiceCollection"/> used for dependency injection, throughout the application
    /// </summary>
    public static partial class ServiceConfiguration
    {

        private static IServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// Adds the scoped services into the <see cref="ServiceCollection"/>
        /// </summary>
        public static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<IHelloWorkRepository, HelloWorkRepository>();

            ServiceProvider = services.BuildServiceProvider();

        }

        /// <summary>
        /// Returns a new instance of the scoped service associated with type <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetProviderService<T>() where T : class
        {
            return (T)ServiceProvider.GetService(typeof(T));
        }

    }
}