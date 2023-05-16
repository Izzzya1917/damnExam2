using examApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
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
            int orderNum = generateOrderNum();
            orderTB.Text+= orderNum;
            
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

            postOrder();
            postSoldItems();

            
        }

        private void postOrder()
        {
            int delievery = 6;
            foreach (Items item in App.orderList)
            {
                if (item.itemCount < 3)
                {
                    delievery = 6;
                    break;
                }
                else delievery = 3;
            }
            Orders newOrder = new Orders()
            {
                orderId = generateOrderNum(),
                orderStatusId = 1,
                orderPlaceId = App.orderPlaceId,
                orderDate = DateTime.Now,
                orderCode = generateOrderCode(),
                orderDelievery = delievery
            };
            db.context.Orders.Add(newOrder);
            db.context.SaveChanges();
            MessageBox.Show("order posted!");
        }

        private void postSoldItems()
        {
            foreach (Items item in App.orderList)
            {
                SoldItems newItem = new SoldItems()
                {
                 itemId = item.itemId,
                 orderId = generateOrderNum()-1
                };
                db.context.SoldItems.Add(newItem);
                db.context.SaveChanges();
                MessageBox.Show("items sold!");
            }
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
