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
using examApp.Models;

namespace examApp.Views.Windows
{
    /// <summary>
    /// Interaction logic for talonWindow.xaml
    /// </summary>
    public partial class talonWindow : Window
    {
        static Core db = new Core();
        List<orderGiveaway> placesList  = db.context.orderGiveaway.ToList();
        public talonWindow()
        {
            InitializeComponent();
            dateTB.Text = App.lastOrder.orderDate.ToString();
            delieveryTB.Text = App.lastOrder.orderDelievery.ToString() + " дней";
            placeTB.Text = placesList[App.orderPlaceId-1].placeName + ", " + placesList[App.orderPlaceId-1].placeAddress;
            codeTB.Text = App.lastOrder.orderCode.ToString();
            foreach (Items item in App.orderList)
            {
                itemsTB.Text += item.itemName+ "\n";
            }
            
        }

        private void closeBtnClick(object sender, RoutedEventArgs e)
        {
            App.lastOrder = null;
            App.orderList .Clear();
            App.CurrentUser = null;
            App.orderPlaceId = 0;
            this.Close();
        }
    }
}
