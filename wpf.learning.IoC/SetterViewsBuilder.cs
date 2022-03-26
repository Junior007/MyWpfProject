﻿using Microsoft.Extensions.DependencyInjection;

namespace wpf.learning.IoC
{
    public class SetterViewsBuilder
    {
        private DependencyContainer _container;

        private SetterViewsBuilder() { }
        internal SetterViewsBuilder(DependencyContainer container)
        {
            _container = container;
        }

        public SetterServicesBuilder SetViews(IEnumerable<Type> viewTypes)
        {
            foreach (var viewType in viewTypes)
            {
                _container.Services.AddSingleton(viewType);
            }
            return new SetterServicesBuilder(_container);
        }
    }
}
