using System;
using System.Collections.Generic;
using System.Linq;
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
using WpfAppPraktos5MVVM.View;

namespace WpfAppPraktos5MVVM.Model
{
    public partial class Secret : Window
    {
        public Secret()
        {
            InitializeComponent();
        }

        private void SecretButton_Click(object sender, RoutedEventArgs e)
        {
            Frameagav.Content = new SecretPage();
        }

        private void Comeback_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
