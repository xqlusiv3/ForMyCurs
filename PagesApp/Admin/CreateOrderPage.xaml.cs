using NPP.ControlsApp.OtherClass;
using NPP.Models;
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

namespace NPP.PagesApp.Admin
{
    public partial class CreateOrderPage : Page
    {
        private readonly NppcreateChihradzeContext _dbContext = new NppcreateChihradzeContext();
        public Contract? contract;

        public CreateOrderPage()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.frameNavigate.GoBack();
        }
        private void LoadComboBoxes()
        {
            WorkerComboBox.ItemsSource = _dbContext.Workers.ToList();
            WorkerComboBox.DisplayMemberPath = "Surname";

            ProductComboBox.ItemsSource = _dbContext.Products.ToList();
            ProductComboBox.DisplayMemberPath = "Name";

            StatusComboBox.ItemsSource = _dbContext.Statuses.ToList();
            StatusComboBox.DisplayMemberPath = "Name";
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(ContractNameTextBox.Text))
            {
                errors.AppendLine("Введите название контракта");
            }

            if (WorkerComboBox.SelectedItem == null)
            {
                errors.AppendLine("Заполните поле 'Работник'");
            }

            if (ProductComboBox.SelectedItem == null)
            {
                errors.AppendLine("Заполните поле 'Продукт'");
            }

            if (StatusComboBox.SelectedItem == null)
            {
                errors.AppendLine("Заполните поле 'Статус'");
            }

            if (ContractDatePicker.SelectedDate == null)
            {
                errors.AppendLine("Заполните поле 'Дата контракта'");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            var newContract = new Contract
            {
                Name = ContractNameTextBox.Text,
                IdWorker = ((Worker)WorkerComboBox.SelectedItem).Id,
                IdOrgProduct = ((Product)ProductComboBox.SelectedItem).Id,
                IdStatus = ((Status)StatusComboBox.SelectedItem).Id,
                DateContract = ContractDatePicker.SelectedDate ?? DateTime.Now
            };

            
            _dbContext.Contracts.Add(newContract);
            _dbContext.SaveChanges();

            MessageBox.Show("Контракт успешно создан");

        }
    }
}
