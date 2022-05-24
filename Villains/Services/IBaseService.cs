namespace Villains.Services
{
    public interface IBaseService
    {
        Task<int> SendRequestAsync(HttpMethod httpMethod,string url);
    }
}
