using examApp.Models;
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

namespace examApp.Views.Pages
{
    /// <summary>
    /// Interaction logic for orderPage.xaml
    /// </summary>
    public partial class orderPage : Page
    {

        Core db = new Core();
        List<Items> arrayItems;
        public orderPage()
        {
            InitializeComponent();
            arrayItems = db.context.Items.ToList();
            CatalogListView.ItemsSource = App.orderList;
            orderTB.Text+=generateOrderNum();
        }

        private void removeBtnClick(object sender, RoutedEventArgs e)
        {

        }

        private void buyBtnClick(object sender, RoutedEventArgs e)
        {

        }

        private int generateOrderNum () {
            List<Orders> orders = db.context.Orders.ToList();
            int lastOrder = orders.Count+1;
            return lastOrder++;
        }
    }
}
