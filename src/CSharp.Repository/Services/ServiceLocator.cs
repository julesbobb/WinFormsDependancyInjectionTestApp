namespace CSharp.Repository.Services
{

    public static class ServiceLocator
    {
        public static IServiceProvider? ServiceProvider;

        public static void SetServiceProvider(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        public static T? GetService<T>() where T : class
        {
            if (ServiceProvider == null)
            {
                throw new InvalidOperationException("Service provider is not set.");
            }

            return ServiceProvider.GetService(typeof(T)) as T;
        }
    }
}
