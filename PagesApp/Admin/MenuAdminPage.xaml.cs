using NPP.ControlsApp.OtherClass;
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
using System.Security.Principal;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace NPP.PagesApp.Admin
{
    public partial class MenuAdminPage : Page
    {
        public MenuAdminPage()
        {   
            InitializeComponent();
        }

        private void ProductButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.frameNavigate.Navigate(new ProductInfoPage());
        }

        private void CreateOrderButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.frameNavigate.Navigate(new CreateOrderPage());
        }

        private void EditOrderButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.frameNavigate.Navigate(new EditOrderPage());
        }

        private void TrackingButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.frameNavigate.Navigate(new TrackingOrderPage());
        }
    }


}



