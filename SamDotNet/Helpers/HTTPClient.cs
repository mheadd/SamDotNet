using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SamDotNet.Helpers
{
    /// <summary>
    /// Base class for HTTPClient.
    /// </summary>
    public interface IHTTPClient 
    {
        string MakeAPICall(string path, string baseURL);
    }

    /// <summary>
    /// Custom exception class.
    /// </summary>
    public class HTTPClientException : Exception
    {
        public HTTPClientException(string message) : base(message) { }
    }
    
    /// <summary>
    /// HTTPClient class.
    /// </summary>
    public class HTTPClient : IHTTPClient
    {
        public HTTPClient()
        {
        }

        public string MakeAPICall(string baseURL, string path)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var result = client.GetStringAsync(path);
                    string response = result.Result;
                    return response;
                }
                catch (AggregateException ex)
                {
                    throw new HTTPClientException(ex.Message);
                }
                catch (Exception)
                {
                    throw new HTTPClientException("An error occured.");
                }
            }
        }
    }
}