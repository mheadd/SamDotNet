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

        /// <summary>
        /// Constructor. Instantiates a new instance of the class.
        /// </summary>
        /// <param name="client">An instance of the HTTPClient class.</param>
        /// <param name="apiKey">An API ket for querying the SAM.gov API.</param>
        public Sam(IHTTPClient client, string apiKey)
        {
            _client = client;
            _apiKey = apiKey;
        }

        /// <summary>
        /// Look up company information.
        /// </summary>
        /// <param name="duns">The DUNS number of the company being searched for.</param>
        /// <param name="PathTemplate">Optional: a custom path template for searching the SAM.gov API.</param>
        /// <param name="SamApiVersion">Optional: the SAM.gov API version to use.</param>
        /// <returns></returns>
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
