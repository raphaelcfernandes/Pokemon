namespace Pokemon.ApiRequester
{
    public interface ISubtypeRequester
    {
        Task<List<string>> GetSubtypes();
    }
}
