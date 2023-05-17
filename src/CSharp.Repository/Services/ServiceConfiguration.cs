using CSharp.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Repository.Services
{
    public static class ServiceConfiguration
    {
        private static IServiceProvider serviceProvider { get; set; }

        /// <summary>
        /// Adds the scoped services into the <see cref="ServiceCollection"/>
        /// </summary>
        /// <param name="forms"></param>
        public static void ConfigureServices(List<Type> forms)
        {
            var services = new ServiceCollection();
            forms?.ForEach(x => services.AddTransient(x));

            services.AddScoped<IHelloWorkRepository, HelloWorkRepository>();
            serviceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        /// Returns a new instance of the scoped service associated with type <typeparamref name="T"/>
        /// </summary>
        public static T GetProviderService<T>() where T : class
        {
            if (serviceProvider == null) return null;
            return (T)serviceProvider.GetService(typeof(T));
        }

        /// <summary>
        /// Creates an instance of the form
        /// </summary>
        public static T CreateForm<T>() where T : Form
        {
            if (serviceProvider == null) return null;
            return (T)serviceProvider.GetService(typeof(T));
        }
    }
}
