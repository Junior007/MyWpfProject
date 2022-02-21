using Microsoft.Extensions.DependencyInjection;
using MyWpfProject.Infrastructure.IoC;
using MyWpfProject.Views;
using System.Windows;

namespace MyWpfProject
{
    public partial class App : Application
    {
        //private ServiceProvider serviceProvider;

        public App()
        {
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            ServiceProvider serviceProvider = DependencyContainer.ServiceProvider();
            var mainWindow = serviceProvider.GetService<MainView>();
            mainWindow.Show();
        }
    }
}
