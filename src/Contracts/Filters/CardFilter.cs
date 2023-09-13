namespace Contracts
{
    public record CardFilter(int Page = 1, int PageSize = 4, string? PokemonName = null);
}
