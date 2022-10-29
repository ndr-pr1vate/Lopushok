using Lopushok.Models;
using Newtonsoft.Json;
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

namespace Lopushok.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public ProductPage()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                var result = App.Client.GetStringAsync("/").Result;
                Products = JsonConvert.DeserializeObject<List<Product>>(result);
                ProductsLv.ItemsSource = Products;

                ListForSend.Visibility = App.ProductsToLoad.Count == 0
                    ? Visibility.Collapsed
                    : Visibility.Visible;
            }
            catch
            {
                MessageBox.Show($"Ошибка получения данных!",
                    "Ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                    );
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void ProductsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ProductsLv.SelectedItem is Product product)
            {
                NavigationService.Navigate( new ProductDetailPage(product));
            }
        }

        private void ListForSend_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductsForLoadPage());
        }

        //private void ProductsLv_Selected(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
