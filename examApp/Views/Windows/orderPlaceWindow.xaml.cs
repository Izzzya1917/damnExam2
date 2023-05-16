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
    /// Interaction logic for orderPlaceWindow.xaml
    /// </summary>
    public partial class orderPlaceWindow : Window
    {
        static Core db = new Core();
        List<orderGiveaway> orderGiveaways = db.context.orderGiveaway.ToList();
        public orderPlaceWindow()
        {
            InitializeComponent();
            delieveryCB.ItemsSource = orderGiveaways;
            delieveryCB.DisplayMemberPath = "placeAddress";
            delieveryCB.SelectedValuePath = "placeId";
        }

        private void selectPlaceBtnClick(object sender, RoutedEventArgs e)
        {
            App.orderPlaceId =Convert.ToInt32(delieveryCB.SelectedValue);
            MessageBox.Show("Selected place " + App.orderPlaceId);
            this.Close();
        }
    }
}
