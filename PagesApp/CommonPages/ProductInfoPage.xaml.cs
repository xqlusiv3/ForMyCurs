using NPP.ControlsApp.OtherClass;
using NPP.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace NPP.PagesApp.CommonPages
{
    /// <summary>
    /// Логика взаимодействия для ProductInfoPage.xaml
    /// </summary>
    public partial class ProductInfoPage : Page
    {
        public ProductInfoPage()
        {
            InitializeComponent();
            ProductListViewer.ItemsSource = NppcreateChihradzeContext.GetContext().Products.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.frameNavigate.GoBack();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                errors.AppendLine("Введите текст.");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            string searchValue = SearchBox.Text.ToLower();

            foreach (var item in ProductListViewer.Items)
            {

                var properties = item.GetType().GetProperties();

                foreach (var prop in properties)
                {
                    string value = prop.GetValue(item)?.ToString()?.ToLower();

                    if (prop.Name == "Count")
                    {
                        continue;
                    }

                    if (!string.IsNullOrEmpty(value) && value.Contains(searchValue))
                    {
                        ProductListViewer.SelectedItem = item;
                        ProductListViewer.ScrollIntoView(item);
                        return;
                    }
                }
            }

            MessageBox.Show("Ничего не найдено");
        }
    }
}
