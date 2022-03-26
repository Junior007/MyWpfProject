using Microsoft.Extensions.DependencyInjection;

namespace wpf.learning.IoC
{
    public class DependencyContainer
    {
        private static DependencyContainer _container;

        public static IServiceProvider ServiceProvider { get => _container._serviceProvider; }
        public static SetterViewsBuilder SetMainView<T>() where T : class
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<T>();

            _container = new DependencyContainer(services);

            return new SetterViewsBuilder(_container);
        }

        internal ServiceProvider _serviceProvider;
        internal ServiceCollection _services;
        private DependencyContainer(ServiceCollection services)
        {
            _services = services;
        }
        internal void BuildServiceProvider()
        {
            _serviceProvider = _services.BuildServiceProvider();
        }


    }
}