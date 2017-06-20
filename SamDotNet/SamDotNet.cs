using System;
using Newtonsoft.Json.Linq;
using SamDotNet.Helpers;

namespace SamDotNet
{
    public class Sam
    {
        /// <summary>
        /// SAM.gov API key
        /// </summary>
        private string _apiKey;

        /// <summary>
        /// Constructor. Instantiates a new instance of the class.
        /// </summary>
        /// <param name="client">An instance of the HTTPClient class.</param>
        /// <param name="apiKey">An API ket for querying the SAM.gov API.</param>
        public Sam(string apiKey)
        {
            _apiKey = apiKey;
        }

        /// <summary>
        /// Look up company information.
        /// </summary>
        /// <param name="duns">The DUNS number of the company being searched for.</param>
        /// <param name="PathTemplate">Optional: a custom path template for searching the SAM.gov API.</param>
        /// <param name="SamApiVersion">Optional: the SAM.gov API version to use.</param>
        /// <returns>JSON Object with API response or error message</returns>
        public JObject GetDunsInfo(string duns, string PathTemplate = Endpoints.DunsInfoPathTemplate, string SamApiVersion = Endpoints.SamApiVersion)
        {
            var path = BuildPath(PathTemplate, new string[] { SamApiVersion, duns, _apiKey });
            return MakeApiCall(Endpoints.SamApiBaseUrl, path);
        }

        /// <summary>
        /// Lookup Sam registration status
        /// </summary>
        /// <param name="duns">The DUNS number of the company being searched for.</param>
        /// <param name="PathTemplate">Optional: a custom path template for searching the SAM.gov API.</param>
        /// <param name="SamApiVersion">Optional: the SAM.gov API version to use.</param>
        /// <returns>JSON Object with API response or error message</returns>
        public JObject GetSamStatus(string duns, string PathTemplate = Endpoints.StatusPathTemplate, string SamApiVersion = Endpoints.SamApiVersion)
        {
            var path = BuildPath(PathTemplate, new string[] { duns });
            return MakeApiCall(Endpoints.SamStatusUrl, path);
        }

        /// <summary>
        /// Utility method to build path for API call.
        /// </summary>
        /// <param name="pathTemplate">The string template used to build the path.</param>
        /// <param name="args">Arguments used to format the string and generate a path</param>
        /// <returns>String representing the path to be used when making an API call</returns>
        private string BuildPath(string pathTemplate, string[] items)
        {
            return String.Format(pathTemplate, items);
        }
        
        /// <summary>
        /// Utilty method to make API call.
        /// </summary>
        /// <param name="baseUrl">The base URL of the API to be invoked.</param>
        /// <param name="path">The path used to call a particular API method.</param>
        /// <returns>JSON Object with API response or error message</returns>
        private JObject MakeApiCall(string baseUrl, string path)
        {
            try
            {
                using (HTTPClient client = new HTTPClient(baseUrl))
                {
                    string response = client.MakeAPICall(path);
                    return JObject.Parse(response);
                }
            }
            catch (HTTPClientException ex)
            {
                return JObject.Parse("{\"error\": \"" + ex.Message + "\"}");
            }
        }
    }
}
