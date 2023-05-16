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
        }
    }
}
