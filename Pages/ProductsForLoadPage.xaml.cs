using Lopushok.Models;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
    /// Логика взаимодействия для ProductsForLoadPage.xaml
    /// </summary>

    public partial class ProductsForLoadPage : Page
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public ProductsForLoadPage()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                var result = App.Client.GetStringAsync("/").Result;
                var products = JsonConvert.DeserializeObject<List<Product>>(result);
                Products = App.ProductsToLoad
                    .Join(products, x => x.ProductId, x => x.Id, (x, y) =>
                    {
                        y.CountInStock = x.Count;
                        return y;
                    })
                    .ToList();
                ProductsToLooadLv.ItemsSource = Products;
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

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(App.ProductsToLoad));

                var result = App.Client.PostAsync("/api/load/?competitor=2", content).Result;
                result.EnsureSuccessStatusCode();

                MessageBox.Show("Список продукции отправлен",
                    "Успех",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                    );

                App.ProductsToLoad.Clear();
                App.SaveProducts();

                NavigationService.GoBack();

            }
            catch
            {

            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
