using MyWpfProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyWpfProject.ViewsModel.Commands
{


    public class DeleteCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return parameter != null;
        }

        public void Execute(object parameter)
        {
            //DataDetail data = parameter as DataDetail;

        }

        public event EventHandler CanExecuteChanged;

    }
}
