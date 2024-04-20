using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using WpfAppPraktos5MVVM.ViewModel.Helpers;
using WpfAppPraktos5MVVM.Model;
using WpfAppPraktos5MVVM.View;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WpfAppPraktos5MVVM.ViewModel
{
    class AuthorViewModel : BindingHelper
    {
        Clicker clickerbutton = new Clicker();
        Secret secretbutton = new Secret();
        MainWindow mainwindow = new MainWindow();
        string parol = "Секрет";
        Window window;
        public BindableCommand Kursor { get ; set; }
        public BindableCommand Clicker { get; set; }
        public BindableCommand Secret { get; set; }


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

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
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

        public AuthorViewModel(Window window)
        {
            this.window = window;
            Kursor = new BindableCommand(_ => Kursor_Click());

            this.window = window;
            Secret = new BindableCommand(_ => secret_Click());

            this.window = window;
            Clicker = new BindableCommand(_ => Clicker_Click());

        }

        public void AddItems()
        {
            Clickervid.Add(selected);
        }
        private void Clicker_Click()
        {
            clickerbutton.Show();
            window.Close();
        }

        private void secret_Click()
        {
            if (parol == password)
            {
                secretbutton.Show();
                window.Close();
            }
        }
        private void Kursor_Click()
        {
            mainwindow.Show();
            window.Close();
        }
    }
}
