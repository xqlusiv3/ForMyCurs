using MaterialDesignThemes.Wpf;
using Microsoft.EntityFrameworkCore;
using NPP.ControlsApp.OtherClass;
using NPP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
using Contract = NPP.Models.Contract;

namespace NPP.PagesApp.Admin
{
    /// <summary>
    /// Логика взаимодействия для EditOrderPage.xaml
    /// </summary>
    public partial class EditOrderPage : Page
    {
        NppcreateChihradzeContext dataEntities = new NppcreateChihradzeContext();
        private readonly NppcreateChihradzeContext _dbContext = new NppcreateChihradzeContext();
        private Contract? contract;
        public EditOrderPage()
        {
            InitializeComponent();
        }

        private void LoadDataGrid(object sender, RoutedEventArgs e)
        {
            {
                var query = from contract in dataEntities.Contracts
                            join status in dataEntities.Statuses on contract.IdStatus equals status.Id
                            join worker in dataEntities.Workers on contract.IdWorker equals worker.Id
                            join post in dataEntities.Posts on worker.IdPost equals post.Id
                            join product in dataEntities.Products on contract.IdOrgProduct equals product.Id
                            select new {ИД = contract.Id, Название = contract.Name, Работник = worker.Surname, ㅤ= worker.Name, Датаㅤзаключения = contract.DateContract, Должность = post.Name, Продукт = product.Name, Статус = status.Name};

                DataGridCreateList.ItemsSource = query.ToList();
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

            // Создаем новый экземпляр окна редактирования контракта и передаем ему выбранный контракт
            var editContractWindow = new Window();
            var editContractPage = new CreateOrderPopupPage();
            editContractWindow.Content = editContractPage;
            editContractWindow.Width = 800;
            editContractWindow.Height = 600;
            editContractWindow.ShowDialog();



            LoadDataGrid(sender, e);
        }


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridCreateList.SelectedItems != null && DataGridCreateList.SelectedItems.Count > 0)
            {
                var result = MessageBox.Show("Вы действительно хотите удалить выбранные элементы?", "Удаление элементов", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    foreach (var item in DataGridCreateList.SelectedItems)
                    {
                        var selectedItem = (dynamic)item;
                        int contractId = selectedItem.ИД;

                        var contractToDelete = dataEntities.Contracts.SingleOrDefault(c => c.Id == contractId);
                        if (contractToDelete != null)
                        {
                            dataEntities.Contracts.Remove(contractToDelete);
                            dataEntities.SaveChanges();
                        }
                    }
                    MessageBox.Show("Элементы успешно удалены!");
                    LoadDataGrid(null, null);
                }
            }
            else
            {
                MessageBox.Show("Выберите элементы для удаления.");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.frameNavigate.GoBack();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility != Visibility.Visible)
            {
                NppcreateChihradzeContext.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DataGridCreateList.ItemsSource = NppcreateChihradzeContext.GetContext().Contracts.ToList();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.frameNavigate.Navigate(new CreateOrderPage());
        }
    }
}
