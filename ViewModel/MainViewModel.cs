using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfAppPraktos5MVVM.ViewModel.Helpers;

namespace WpfAppPraktos5MVVM.ViewModel
{
    internal class MainViewModel : BindingHelper
    {
        private ClickerVid selected;
        public ClickerVid Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<ClickerVid> clickervid;
        public ObservableCollection<ClickerVid> Clickervid
        {
            get { return clickervid; }
            set
            {
                clickervid = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            Clickervid = new ObservableCollection<ClickerVid>()
            {
                new ClickerVid("Лакшеры", "Красный"),
                new ClickerVid("Дудос", "Белый")
            };
        }
    }
}
