using System;
using Newtonsoft.Json.Linq;
using SamDotNet.Helpers;

namespace SamDotNet
{
    public class Sam
    {
        private readonly IHTTPClient _client;
        private string _apiKey;
        private const string _samApiVersion = "v4";
        private const string _pathTemplate = "sam/{0}/registrations/{1}?api_key={2}";

        public Sam(IHTTPClient client, string apiKey)
        {
            _client = client;
            _apiKey = apiKey;
        }

        public JObject GetDunsInfo(string duns, string PathTemplate = _pathTemplate, string SamApiVersion = _samApiVersion)
        {
            var path = String.Format(PathTemplate, SamApiVersion, duns, _apiKey);
            try
            {
                string response = _client.MakeAPICall(path);
                JObject json = JObject.Parse(response);
                return json;
            }
            catch (HTTPClientException ex)
            {
                JObject json = JObject.Parse("{\"error\": \"" + ex.Message + "\"}");
                return json;
            }

        }
    }
}
