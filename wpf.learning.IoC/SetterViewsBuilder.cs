using Microsoft.Extensions.DependencyInjection;

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

        public ServiceProvider BuildServiceProvider()
        {
            _container.BuildServiceProvider();
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
