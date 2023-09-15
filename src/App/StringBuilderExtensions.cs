namespace Pokemon
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder WithFilter(this StringBuilder sb, CardFilter filter) 
        {
            sb.Append("?");
            sb.Append($"page={filter.Page}&pageSize={filter.PageSize}&q=");

            if (filter.PokemonName is not null)
            {
                sb.Append($"name:{filter.PokemonName}");
            }

            return sb;
        }

        public static StringBuilder WithFilter(this StringBuilder sb, SetFilter filter)
        {
            sb.Append("?");
            sb.Append($"page={filter.Page}&pageSize={filter.PageSize}&q=");

            if (filter.PokemonName is not null)
            {
                sb.Append($"name:{filter.PokemonName}");
            }

            return sb;
        }
    }
}
