using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Contracts;
using Newtonsoft.Json;

namespace Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string Name = "test";
        private readonly HttpClient httpClient;
        private readonly Uri baseUri = new Uri("https://api.pokemontcg.io/v2/");

        public MainWindow()
        {
            this.httpClient = new HttpClient() { BaseAddress = this.baseUri};
            InitializeComponent();
        }

        private async void InitHandler(object sender, EventArgs e)
        {
            //HttpResponseMessage responseMessage = await this.httpClient.GetAsync("cards/gym2-2");
            HttpResponseMessage responseMessage = await this.httpClient.GetAsync("cards?q=name:Victreebel");
            var res = await responseMessage.Content.ReadAsStringAsync();
            ApiResource<Card> getResponse = JsonConvert.DeserializeObject<ApiResource<Card>>(res, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            foreach (Card card in getResponse.Results)
            {
                cardImage.Source = new BitmapImage(new Uri(card.Images.Large));
                await Task.Delay(2000);
            }
        }
    }
}
