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
using Newtonsoft.Json;
using Parser.BLL;
using Parser.Models;

namespace Parser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Formatter _formatter = new Formatter();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async Task GetAllSite()
        {
            var result = await _formatter.GetImagesFromUrl(
                 "https://101hotels.com/api/hotel/search?r=0.16883927403993204&params=%7B%22city_ids%22%3A%5B75%5D%2C%22hotel_ids%22%3A%5B%5D%2C%22destination%22%3A%7B%7D%7D");

            Oleg.ItemsSource = result;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await GetAllSite();
        }
    }
}
