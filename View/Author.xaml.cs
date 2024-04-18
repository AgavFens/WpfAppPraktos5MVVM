using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAppPraktos5MVVM.Model;
using WpfAppPraktos5MVVM.View;

namespace WpfAppPraktos5MVVM.ViewModel
{ 
    public partial class Author : Window
    {
        Clicker clickerbutton = new Clicker();
        Secret secretbutton = new Secret();
        MainWindow mainwindow = new MainWindow();
        string parol = "Секрет";
        public Author()
        {
            InitializeComponent();
        }
        private void Clicker_Click(object sender, RoutedEventArgs e)
        {
            clickerbutton.Show();
            Close();
        }

        private void secret_Click(object sender, RoutedEventArgs e)
        {
            if (parol == Password.Text)
            {
                secretbutton.Show();
                Close();
            }
        }
        private void Kursor_Click(object sender, RoutedEventArgs e)
        {
            mainwindow.Show();
            Close();
        }
    }
}
