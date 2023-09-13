namespace Pokemon.ApiRequester
{
    public interface ICardRequester
    {
        Task<Card> GetCardByIdAsync(string id);

        Task<List<Card>> SearchCards(CardFilter filter);
    }
}
