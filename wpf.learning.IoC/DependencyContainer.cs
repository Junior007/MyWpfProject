using Microsoft.Extensions.DependencyInjection;

namespace wpf.learning.IoC
{
    public class DependencyContainer
    {
        private static DependencyContainer _container;

        public static IServiceProvider ServiceProvider { get => _container.SrvcProvider; }
        public static SetterViewsBuilder SetMainView<T>() where T : class
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<T>();

            _container = new DependencyContainer(services);

            return new SetterViewsBuilder(_container);
        }

        internal ServiceProvider SrvcProvider;
        internal ServiceCollection Services;
        private DependencyContainer(ServiceCollection services)
        {
            Services = services;
        }
        internal void BuildServiceProvider()
        {
            SrvcProvider = Services.BuildServiceProvider();
        }
    }
}