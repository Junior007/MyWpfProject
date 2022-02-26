using Microsoft.Extensions.DependencyInjection;
using MyWpfProject.Services;
using MyWpfProject.Views;
using MyWpfProject.ViewsModel;

namespace MyWpfProject.Infrastructure.IoC
{
    internal class DependencyContainer
    {
        private static ServiceProvider _serviceProvider;

        internal static ServiceProvider ServiceProvider()
        {
            if (_serviceProvider == null)
            {
                ServiceCollection services = RegisterServices();
                _serviceProvider = services.BuildServiceProvider();
            }
            return _serviceProvider;
        }

        private static ServiceCollection RegisterServices()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddSingleton<IDataService, DataService>();

            services.AddSingleton<MainView>();
            services.AddScoped<MainViewModel>();
            return services;
        }

    }
}
