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
using examApp.Views.Windows;

namespace examApp.Views.Pages
{
    /// <summary>
    /// Interaction logic for orderPage.xaml
    /// </summary>
    public partial class orderPage : Page
    {

        Core db = new Core(); 
        public orderPage()
        {
            InitializeComponent();
            orderListView.ItemsSource = App.orderList;
            orderTB.Text+=generateOrderNum();
            
        }

        private void removeBtnClick(object sender, RoutedEventArgs e)
        {
            Items selectedItem = (Items)((Button)sender).DataContext;
            App.orderList.Remove(selectedItem);
            orderListView.ItemsSource = App.orderList;
        }

        private void buyBtnClick(object sender, RoutedEventArgs e)
        {
            orderPlaceWindow orderPlaceWindow = new orderPlaceWindow();

            orderPlaceWindow.ShowDialog();
            /*
            Orders newOrder= new Orders()
                {
                    orderId = generateOrderNum(),
                    orderStatusId = 1,
                    orderPlaceId = 1,
                    orderDate = DateTime.Now,
                    orderCode = generateOrderCode(),
                    orderDelievery = 1
                };
                db.context.Orders.Add(newOrder);
                db.context.SaveChanges();
            MessageBox.Show("Заказ оформлен!");*/
        }

        private int generateOrderNum () {
            List<Orders> orders = db.context.Orders.ToList();
            int lastOrder = orders.Count+1;
            return lastOrder++;
        }

        private int generateOrderCode()
        {
            Random rnd = new Random();  
            return rnd.Next(100, 999);
        }
    }
}
