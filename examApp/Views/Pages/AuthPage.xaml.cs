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
    /// Interaction logic for AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
            loginTB.Focus();
        }




        private void loginBtnClick(object sender, RoutedEventArgs e)
        {
            try {
                login(loginTB.Text, passwordPB.Password);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
            //тут авторизация
        }

        private void guestBtnClick(object sender, RoutedEventArgs e)
        {
            //тут просто скипаем и идём смотреть товары
            NavigationService.Navigate(new CatalogPage());
        }

        //авторизация
        private Boolean login(string login, string password)
        {
            Core db = new Core();
            List<Roles> arrayRoles;
            arrayRoles = db.context.Roles.ToList(); 
            if (String.IsNullOrEmpty(login) && String.IsNullOrEmpty(password)) {
                throw new Exception("Пусто!");
            }
            if ((db.context.Users.Where(x => x.userLogin == login).FirstOrDefault() != null)
                && (db.context.Users.Where(x => x.userPassword == password).FirstOrDefault() != null))
            {
                App.CurrentUser = db.context.Users.Where(x => x.userLogin == login).FirstOrDefault();
                MessageBox.Show("Вас зовут " + App.CurrentUser.userName + ", "
                    + "Вы - " + arrayRoles[Convert.ToInt32(App.CurrentUser.userRoleId)-1].roleName);
            }
            else throw new Exception("Аккаунт не найден!");
            return true;
        }
    }
}
