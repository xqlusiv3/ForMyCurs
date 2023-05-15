using NPP.ControlsApp.OtherClass;
using NPP.Models;
using NPP.PagesApp.Admin;
using NPP.PagesApp.User;
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

namespace NPP.Pages.Home
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private NppcreateChihradzeContext _context { get; set; }

        public LoginPage(NppcreateChihradzeContext connect)
        {
            InitializeComponent();
            _context = connect;
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var data = _context.Users.FirstOrDefault(x => x.Login == TxbLogin.Text && x.Password == PsbPass.Password);
                if (data is not null)
                {
                    if (data.IdRole == 1)
                    {
                        var adminPage = new MenuAdminPage();
                       MessageBox.Show("Добро пожаловать!");
                       NavigationService.Navigate(adminPage);
                    }

                    else
                    {
                        var userPage = new MenuUserPage();
                        MessageBox.Show("Добро пожаловать!");
                        NavigationService.Navigate(userPage);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль.");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.frameNavigate.Navigate(new CreateAccountPage());
        }
    }
}
