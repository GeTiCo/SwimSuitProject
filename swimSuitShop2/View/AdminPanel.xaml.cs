using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

namespace swimSuitShop2.View
{
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        int limit = 4;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string pass = "admin";
            string log = "admin";

            if (pass == password.Password && log == login.Text)
            {
                View.settings newOrder = new View.settings();
                this.Hide();
                newOrder.ShowDialog();
            }
            limit--;
            limits.Text = $"У вас осталось {limit} попыток";
            if (limit == 0)
            {
                limits.Text = $"Вход заблокирован, покиньте этот раздел";
                btnNext.IsEnabled = false;
            }
        }
    }
}
