using Microsoft.Extensions.DependencyInjection;

namespace wpf.learning.IoC
{
    public class SetterViewsBuilder
    {
        private Container _container;
        internal SetterViewsBuilder(Container container)
        {
            _container = container;
        }

        public ServiceProvider Build()
        {
            _container._serviceProvider = _container._services.BuildServiceProvider();
            return _container._serviceProvider;
        }

        public SetterViewsBuilder SetViews(IEnumerable<Type> viewTypes)
        {
            foreach (var viewType in viewTypes)
            {
                _container._services.AddSingleton(viewType);
            }
            return this;
        }
    }
}
