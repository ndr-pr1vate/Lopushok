using Lopushok.Models;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace Lopushok
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string productsToLoadFileName = "products.json";

        public static HttpClient Client { get; set; }

        public static List<LoadModel> ProductsToLoad { get; set; } = new List<LoadModel>();

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("http://169.254.131.1");
            Client.Timeout = TimeSpan.FromSeconds(5);

            try
            {
                var result = Client.GetAsync("/").Result;
                result.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сервер недоступен!",
                    "Ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                    );
                Environment.Exit(0);
            }
        }

        public static void LoadProducts()
        {
            try
            {
                if (!File.Exists(productsToLoadFileName))
                    return;

                var products = JsonConvert.DeserializeObject<List<LoadModel>>(File.ReadAllText(productsToLoadFileName));
                ProductsToLoad = products
                    .GroupBy(x => x.ProductId)
                    .Select(x => new LoadModel()
                    {
                        ProductId = x.Key,
                        Count = x.Sum(y => y.Count)
                    }).ToList();
            }
            catch (Exception)
            {
            }
        }

        public static void SaveProducts()
        {
            try
            {
                var products = ProductsToLoad
                    .GroupBy(x => x.ProductId)
                    .Select(x => new LoadModel()
                    {
                        ProductId = x.Key,
                        Count = x.Sum(y => y.Count)
                    }).ToList();
                ProductsToLoad = products;
                File.WriteAllText(productsToLoadFileName, JsonConvert.SerializeObject(products));
            }
            catch (Exception)
            {
            }
        }
    }
}
