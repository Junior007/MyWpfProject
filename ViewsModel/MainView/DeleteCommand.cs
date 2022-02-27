using MyWpfProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MyWpfProject.ViewsModel.MainView
{


    public class DeleteCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //DataDetail data = parameter as DataDetail;
            MessageBoxResult result = MessageBox.Show("DeleteCommand Hello MessageBox");

        }
    }
}
