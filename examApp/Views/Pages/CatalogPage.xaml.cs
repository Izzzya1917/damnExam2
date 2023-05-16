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
using examApp.Models;

namespace examApp.Views.Pages
{
    /// <summary>
    /// Interaction logic for CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {

        Core db = new Core();
        List<Items> arrayItems;
        public CatalogPage()
        {
            InitializeComponent();
            arrayItems = db.context.Items.ToList();
            CatalogListView.ItemsSource = arrayItems;
            if (App.orderList.Count > 0 )
            {
                orderBtn.Visibility = Visibility.Visible;
            } else
            orderBtn.Visibility = Visibility.Hidden;
        }


        private void addToCartBtnClick(object sender, RoutedEventArgs e)
        {
            Items selectedItem = (Items)((Button)sender).DataContext;
            App.orderList.Add(selectedItem);
            orderBtn.Visibility = Visibility.Visible;
        }

        private void orderBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new orderPage());
        }
    }
}
