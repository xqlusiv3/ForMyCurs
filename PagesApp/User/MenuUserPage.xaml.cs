﻿using NPP.ControlsApp.OtherClass;
using NPP.PagesApp.CommonPages;
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

namespace NPP.PagesApp.User
{
    /// <summary>
    /// Логика взаимодействия для MenuUserPage.xaml
    /// </summary>
    public partial class MenuUserPage : Page
    {
        public MenuUserPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProductButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.frameNavigate.Navigate(new ProductInfoPage());
        }
    }
}
