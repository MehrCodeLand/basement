namespace Service.Leyer.Repositories.ValidationRepo
{
    public interface IValidationRepository
    {
        Task<bool> IsAllString(string name);
    }
}