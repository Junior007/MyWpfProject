using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
namespace MyWpfProject.ViewsModel.Infrastructure
{
    internal class GetViews
    {
        public static IEnumerable<Type> Types()
        {
            var type = typeof(INotifyPropertyChanged);

            Assembly assembly = Assembly.GetExecutingAssembly();

            IEnumerable<Type> viewNames = assembly
                .GetTypes()
                .Where(types => types.Name != type.Name && types.IsAssignableTo(type));
                //.Select(type => type.Name);

            return viewNames;
        }
    }
}
