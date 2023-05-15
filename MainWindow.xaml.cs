using NPP.ControlsApp.OtherClass;
using NPP.Pages;
using NPP.Pages.Home;
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

namespace NPP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            NavigationClass.frameNavigate = FrameMain;

            FrameMain.Navigate(new LoginPage(new Models.NppcreateChihradzeContext()));
        }

        private void FrameMain_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
