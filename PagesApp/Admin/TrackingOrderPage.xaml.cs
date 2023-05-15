using NPP.ControlsApp.OtherClass;
using NPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace NPP.PagesApp.Admin
{
    /// <summary>
    /// Логика взаимодействия для TrackingOrderPage.xaml
    /// </summary>
    public partial class TrackingOrderPage : Page
    {
        NppcreateChihradzeContext dataEntities = new NppcreateChihradzeContext();
        public TrackingOrderPage()
        {
            InitializeComponent();

        }


        private void ButtonTracker_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(ContractIdTextBox.Text))
            {
                errors.AppendLine("Введите ИД контракта");
            }

            if (!int.TryParse(ContractIdTextBox.Text, out int contractId))
            {
                errors.AppendLine("ИД контракта должен состоять только из цифр");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            using (var context = new NppcreateChihradzeContext())
            {
                Contract contract = context.Contracts.Find(contractId);

                if (contract != null)
                {
                    ContractDataGrid.ItemsSource = new List<Contract> { contract };
                }
                else
                {
                    MessageBox.Show($"Контракт с ИД = {contractId} не найден!");
                }
            }

        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.frameNavigate.GoBack();
        }

    }
}
