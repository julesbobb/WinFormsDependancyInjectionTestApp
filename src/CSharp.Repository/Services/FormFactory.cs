﻿using CSharp.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CSharp.Repository.Services
{
    public class FormFactory : IFormFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public FormFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public T CreateForm<T>() where T : Form
        {
            return _serviceProvider.GetRequiredService<T>();
        }
    }
}
