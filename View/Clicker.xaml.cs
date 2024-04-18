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

namespace WpfAppPraktos5MVVM.View
{
    public partial class Clicker : Window
    {
        public int money = 0;
        public int multi = 1;
        public int upgradecost = 20;
        public int upgradescount = 0;
        public Clicker()
        {
            InitializeComponent();
        }

        private void Click_Click(object sender, RoutedEventArgs e)
        {
            money++;
            Label1.Text = $"Деньги: {money}$";
        }
    }
}
