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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace swimSuitShop2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

    private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Кнопка Каталог
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            View.Catalog newOrder = new View.Catalog();
            this.Hide();
            newOrder.ShowDialog();
            this.Show();
        }
        //Кнопка Оформления заказа (Этап: Создание)
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            View.MakeOrder newOrder = new View.MakeOrder();
            this.Hide();
            newOrder.ShowDialog();
            this.Show();
        }
        //Кнопка Редактирования (Этап: Проверка)
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            View.AdminPanel newOrder = new View.AdminPanel();
            this.Hide();
            newOrder.ShowDialog();
            this.Show();
        }
    }
}
