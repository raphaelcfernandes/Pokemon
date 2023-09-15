﻿namespace Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ICardRequester cardRequester;
        private int page = 1;
        private int pageSize = 10;
        private double totalPage = 0;

        public MainWindow(ICardRequester cardRequester)
        {
            InitializeComponent();
            this.cardRequester = cardRequester;
            this.DataContext = this.Cards;
        }

        public ObservableCollection<Card> Cards { get; } = new ObservableCollection<Card>();

        public int GridColumns { get; set; } = 5;

        private async void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.page = 1;
                await this.RenderCards();
            }
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
            if (this.page < this.totalPage)
            {
                this.page++;
            }
            
            await this.RenderCards();
        }

        private async Task RenderCards()
        {
            if (string.IsNullOrEmpty(this.QueryText.Text))
            {
                return;
            }

            this.searchButton.IsEnabled = false;
            ApiResourceAsList<Card> cards = await this.cardRequester.SearchCardsAsApiResourceList(new CardFilter()
            {
                PokemonName = this.QueryText.Text,
                Page = this.page,
                PageSize = this.pageSize
            });

            this.Cards.Clear();
            foreach(Card card in cards.Results)
            {
                this.Cards.Add(card);
            }
            this.DataContext = this.Cards;
            this.totalPage = Math.Ceiling((double)cards.TotalCount / (double)this.pageSize);
            this.searchButton.IsEnabled = true;
            if (this.Cards.Count > 5)
            {
                this.GridColumns = this.Cards.Count / 2;
            }
            else
            {
                this.GridColumns = this.Cards.Count;
            }
        }
    }
}
