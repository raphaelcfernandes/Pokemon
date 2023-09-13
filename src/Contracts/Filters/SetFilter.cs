namespace Contracts
{
    public record SetFilter(int Page = 1, int PageSize = 4, string? PokemonName = null);
}
