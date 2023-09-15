using System.Diagnostics;

namespace Pokemon
{
    public partial class CardDetailModal : Window
    {
        public CardDetailModal(Card card) 
        {
            InitializeComponent();
            this.Card = card;
            this.DataContext = this.Card;
        }

        public Card Card { get; }
    }
}
