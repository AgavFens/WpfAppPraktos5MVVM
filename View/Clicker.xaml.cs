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
            money = money + multi;
            Label1.Content = $"Деньги: {money}$";
        }

        private void upgrade_Click(object sender, RoutedEventArgs e)
        {
            if (money > upgradecost - 1)
            {
                money = money - upgradecost;
                Label1.Content = $"Деньги: {money}$";
                upgradecost++;
                Label2.Content = $"Количество прокачек кликов: {upgradecost}";
                upgradecost = upgradecost * 2;
                Label3.Content = $"Стоимость прокачки: {upgradecost}$";
                Label4.Content = $"Деньги за клик: {multi}";
            }
            else
            {
                MessageBox.Show("Нет денег", "ошибка");
            }
        }

    }
}
