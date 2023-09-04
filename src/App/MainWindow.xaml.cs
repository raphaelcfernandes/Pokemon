using System;
using System.Net.Http;
using System.Windows;

namespace Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly HttpClient httpClient;
        private readonly Uri baseUri = new Uri("https://api.pokemontcg.io/v2/");

        public MainWindow()
        {
            this.httpClient = new HttpClient() { BaseAddress = this.baseUri};
            InitializeComponent();
        }
    }
}
