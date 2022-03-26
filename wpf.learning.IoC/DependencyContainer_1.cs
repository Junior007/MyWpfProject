using Microsoft.Extensions.DependencyInjection;

namespace wpf.learning.IoC
{
    public class Container
    {
        private static Container _container;

        public static IServiceProvider ServiceProvider { get => _container._serviceProvider; }
        public static SetterViewsBuilder SetMainView<T>() where T : class
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<T>();

            _container = new Container(services);

            return new SetterViewsBuilder(_container);
        }

        internal ServiceProvider _serviceProvider;
        internal ServiceCollection _services;
        private Container(ServiceCollection services)
        {
            _services = services;
        }


    }
}