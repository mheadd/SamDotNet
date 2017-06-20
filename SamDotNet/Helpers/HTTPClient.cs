using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SamDotNet.Helpers
{
    public interface IHTTPClient: IDisposable
    {
        string MakeAPICall(string path);
    }

    public class HTTPClientException : Exception
    {
        public HTTPClientException(string message) : base(message) { }
    }
    public class HTTPClient : IHTTPClient
    {
        private string _baseUrl;
        public HTTPClient(string baseURL)
        {
            _baseUrl = baseURL;
        }

        public string MakeAPICall(string path)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    string response = client.GetStringAsync(path).Result;
                    return response;
                }
                catch (HttpRequestException ex)
                {
                    throw new HTTPClientException(ex.Message);
                }
                catch (Exception)
                {
                    throw new HTTPClientException("An error occured.");
                }
            }
        }

        public void Dispose()
        {
        }
    }
}