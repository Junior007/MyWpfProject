using MyWpfProject.Models;
using MyWpfProject.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyWpfProject.ViewsModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private IDataService _dataService;

        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService ?? throw new ArgumentNullException(nameof(dataService));

            DataDetails = new ObservableCollection<DataDetail>(_dataService.GetDataDetails());
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ObservableCollection<DataDetail> DataDetails { get; set; }

        private DataDetail _dataDetail;
        public DataDetail DataDetail
        {
            get => _dataDetail;
            set
            {
                _dataDetail = value;
                OnPropertyChanged();
            }
        }
    }
}
