namespace SamDotNet.Helpers
{
    public static class Endpoints
    {
        /// <summary>
        /// The base URL for looking up company information.
        /// </summary>
        public const string SamApiBaseUrl = "https://api.data.gov";
        /// <summary>
        /// The base URL for looking up registration status.
        /// </summary>
        public const string SamStatusUrl = "https://www.sam.gov";
        /// <summary>
        /// The SAM.gov API version to use
        /// </summary>
        public const string SamApiVersion = "v4";
        /// <summary>
        /// A string for constructing a path to lookup information on a company using a DUNS number.
        /// </summary>
        public const string DunsInfoPathTemplate = "sam/{0}/registrations/{1}?api_key={2}";
        /// <summary>
        /// A string for construcing a path to lookup up registration status based on a DUNS number.
        /// </summary>
        public const string StatusPathTemplate = "samdata/registrations/trackProgress/{0}";
    }
}