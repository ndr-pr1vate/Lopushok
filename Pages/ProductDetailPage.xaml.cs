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
    /// Логика взаимодействия для ProductDetailPage.xaml
    /// </summary>
    public partial class ProductDetailPage : Page
    {
        public Product Product { get; set; }
        public ProductDetailPage()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                var result = App.Client.GetStringAsync("/").Result;
                var products = JsonConvert.DeserializeObject<List<Product>>(result);
                Product = products.FirstOrDefault(x => x.Id == Product.Id);
                ProductInfoGrid.DataContext = Product;
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

        public ProductDetailPage(Product product)
        {
            InitializeComponent();
            Product = product;
            ProductInfoGrid.DataContext = Product;
        }
        private void ChangeCount(int value)
        {
            try
            {
                var body = new ChangeCountModel()
                {
                    ProductId = Product.Id,
                    Add = value
                };
                var response = App.Client.PostAsync("/api/changeCount",
                    new StringContent(JsonConvert.SerializeObject(body))).Result;
                response.EnsureSuccessStatusCode();
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
        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeCount(-1);
            LoadData();
            MinusBtn.IsEnabled = Product.CountInStock > 0;
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeCount(1);
            LoadData();
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            //var count = Interaction.InputBox("Введите кол-во продукции:", "", "1");
            //if(int TryParse(countString, out var count) || count <= 0)
            //        {
            //    MessageBox.Show("Введите целое положительное число",
            //        "Ошибка",
            //        MessageBoxButton.OK,
            //        Mes)
            //}
        }
    }
}
