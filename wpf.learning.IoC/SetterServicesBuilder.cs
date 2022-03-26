using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf.learning.application.Service;

namespace wpf.learning.IoC
{
    public class SetterServicesBuilder
    {
        private DependencyContainer _container;

        private SetterServicesBuilder(){}
        internal SetterServicesBuilder(DependencyContainer container)
        {
            _container = container;
        }

        public ServiceProvider BuildServiceProvider()
        {
            _container.BuildServiceProvider();
            return _container.SrvcProvider;
        }
        public SetterServicesBuilder SetServices()
        {
            _container.Services.AddSingleton<IDataService, DataService>();

            return this;
        }


    }
}
