using Microsoft.Extensions.DependencyInjection;
using wpf.learning.application.Service;

namespace wpf.learning.IoC
{
    public class DependencyContainer
    {
        private static ServiceProvider _serviceProvider;

        public static ServiceProvider ServiceProvider(IEnumerable<System.Type> nameViews)
        {
            if (_serviceProvider == null)
            {
                ServiceCollection services = RegisterServices(nameViews);
                _serviceProvider = services.BuildServiceProvider();
            }

            return _serviceProvider;
        }

        private static ServiceCollection RegisterServices(IEnumerable<System.Type> nameViews)
        {
            ServiceCollection services = new ServiceCollection();

            //ViewModel
            foreach (var nameView in nameViews)
            {
                services.AddSingleton(nameView);
            }


            services.AddSingleton<IDataService, DataService>();
            //services.AddSingleton<MainView>();

            return services;
        }

    }
}
