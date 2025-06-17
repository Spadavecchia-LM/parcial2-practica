using RestSharp;

namespace apiConsumer.Interfaces
{
    public interface IApiConnector
    {
        Task<T> Connect<T>(Method method, string urlMethod, object objectToPost = null);
        Task<T> GetAsync<T>(string method);
    }
}
