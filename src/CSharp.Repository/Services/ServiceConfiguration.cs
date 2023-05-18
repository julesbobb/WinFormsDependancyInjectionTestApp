using CSharp.Forms.Data;
using CSharp.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        /// <param name="Configuration"></param>
        public static void ConfigureServices(List<Type> forms, IConfiguration configuration)
        {
            var services = new ServiceCollection();
            forms?.ForEach(x => services.AddTransient(x));
            services.AddSingleton(configuration);
            services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase(configuration.GetConnectionString("WinformsDatabase")));
            services.AddScoped<IHelloWorkRepository, HelloWorkRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
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
