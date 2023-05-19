namespace CSharp.Repository.Services
{

    public static class ServiceLocator
    {
        private static IServiceProvider? _serviceProvider;

        public static void SetServiceProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public static T? GetService<T>() where T : class
        {
            if (_serviceProvider == null)
            {
                throw new InvalidOperationException("Service provider is not set.");
            }

            return _serviceProvider.GetService(typeof(T)) as T;
        }
    }
}
