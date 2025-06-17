
using apiConsumer;
using apiConsumer.Interfaces;
using RestSharp;
using System.Net;


namespace APIConsumer.Tools
{
    public class ApiConnector : IApiConnector
    {
      
        private readonly RestClient _client;
        public ApiConnector(IConfiguration config)
        {
            _client = new RestClient(Program._configuration["DataLayer:URL"]);
        }


        public async Task<T> Connect<T>(Method method, string urlMethod, object objectToPost = null)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
            var request = new RestRequest(urlMethod)
            {
                Method = method
            };


            try
            {
                RestResponse<T> response;

                switch(method)
                {
                    case Method.Get:
                        response = await _client.ExecuteGetAsync<T>(request);
                        break;
                    case Method.Post:
                            if (objectToPost == null)
                            {
                                throw new ArgumentNullException(nameof(objectToPost), "Object to post cannot be null for POST method.");
                        }
                            request.AddJsonBody(objectToPost);
                            response = await _client.ExecutePostAsync<T>(request);
                        break;
                    case Method.Put:
                        if (objectToPost == null)
                        {
                            throw new ArgumentNullException(nameof(objectToPost), "Object to post cannot be null for POST method.");
                        }
                        request.AddJsonBody(objectToPost);
                        response = await _client.ExecutePutAsync<T>(request);
                        break;
                    case Method.Delete:
                        response = await _client.ExecuteDeleteAsync<T>(request);
                        break;
                    default:
                        throw new NotSupportedException($"Method {method} is not supported.");
                }

                if (response.IsSuccessful)
                {
                    return response.Data;
                }
                else
                {
                    throw new ApplicationException($"HTTP request failed: {response.StatusCode} - {response.ErrorMessage} - {response.Content}");
                }


            }
            catch (Exception ex)
            {
                // Handle exceptions here
                throw new ApplicationException("Failed to execute HTTP request", ex);
            }
        }

        public async Task<T> GetAsync<T>(string method)
        {
            return await Connect<T>(Method.Get, method);
        }
    }
}