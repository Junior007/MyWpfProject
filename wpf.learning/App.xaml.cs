using Microsoft.Extensions.DependencyInjection;
using wpf.learning.Infrastructure;
using MyWpfProject.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using wpf.learning.IoC;

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
            IEnumerable<Type> viewTypes = GetViews.Types();
            ServiceProvider serviceProvider = Container.SetMainView<MainView>().SetViews(viewTypes).Build();
            var mainWindow = serviceProvider.GetService<MainView>();
            mainWindow.Show();
        }
    }
}
