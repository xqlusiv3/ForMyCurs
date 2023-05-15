using Microsoft.EntityFrameworkCore;
using NPP.ControlsApp.OtherClass;
using NPP.Models;
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
    /// Логика взаимодействия для CreateAccountPage.xaml
    /// </summary>
    public partial class CreateAccountPage : Page
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Login = TxbLogin.Text;
                string Password = PsbPass.Password;
                string PasswordCheck = PsbPassCheck.Password;

                if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(PasswordCheck))
                {
                    throw new Exception("Заполните все поля.");
                }

                if (Password != PasswordCheck)
                {
                    throw new Exception("Пароли не совпадают.");
                }
                
                User newUser = new User
                {
                    Login = Login,
                    Password = Password,
                    IdRole = 2,
                };

                using (var context = new NppcreateChihradzeContext())
                {
                    context.Users.Add(newUser);
                    context.SaveChanges();
                }

                TxbLogin.Text = "";
                PsbPass.Password = "";
                PsbPassCheck.Password = "";

                MessageBox.Show("Вы зарегестировались!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LogNavButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.frameNavigate.GoBack();
        }
    }
}
