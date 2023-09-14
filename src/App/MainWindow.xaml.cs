namespace Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ICardRequester cardRequester;
        private List<Card> cards = new();
        private int page = 1;
        private int gridSize = 4;

        public MainWindow(ICardRequester cardRequester)
        {
            this.cardRequester = cardRequester;
            InitializeComponent();
        }

        private async void Search_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.QueryText.Text))
            {
                return;
            }

            this.page = 1;
            await this.RenderCards();
        }

        private async void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.page > 1)
            {
                this.page--;
            }
            await this.RenderCards();
        }

        private async void NextButton_Click(object sender, RoutedEventArgs e)
        {
            this.page++;
            await this.RenderCards();
        }

        private async Task RenderCards(string pokemonName = "Alakazam")
        {
            this.searchButton.IsEnabled = false;
            this.cards = await this.cardRequester.SearchCards(new CardFilter()
            {
                PokemonName = string.IsNullOrEmpty(this.QueryText.Text) ? pokemonName : this.QueryText.Text,
                Page = this.page,
                PageSize = this.gridSize
            });

            if (this.cards.Any())
            {
                cardImage.Source = new BitmapImage(new Uri(cards[0].Images.Large));
                cardImage1.Source = new BitmapImage(new Uri(cards[1].Images.Large));
                cardImage2.Source = new BitmapImage(new Uri(cards[2].Images.Large));
                cardImage3.Source = new BitmapImage(new Uri(cards[3].Images.Large));
            }
            this.searchButton.IsEnabled = true;
        }
    }
}
