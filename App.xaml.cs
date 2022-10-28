using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        public static HttpClient Client { get; set; }

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
            //if(File.Exist(product.json))
        }
    }
}
