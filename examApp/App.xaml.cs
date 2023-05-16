using examApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace examApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       private  Core db = new Core();   

        public static Users CurrentUser = null;
        public static List<Items> orderList = new List<Items>();
        public static int orderPlaceId =0;
        public static Orders lastOrder = null;


    }
}
