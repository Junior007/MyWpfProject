﻿using Microsoft.Extensions.DependencyInjection;

namespace wpf.learning.IoC
{
    public class Builder
    {
        private Container _container;

        private Builder()
        {

        }
        
        internal Builder(Container container)
        {
            _container = container;
        }
     
        public ServiceProvider Build()
        {
            _container.BuildServiceProvider();
            return _container.SrvcProvider;
        }
    }
}
