using Xunit;
using SamDotNet.Helpers;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace SamDotNet.Tests
{
    public class SamClientTests
    {
        private readonly string _key = "DUMMY_KEY";

        public class TestHTTPClient : IHTTPClient
        {
            public string MakeAPICall(string path, string baseURL)
            {
                return "{\"foo\": \"bar\"}";
            }
            public void Dispose()
            {
            }
        }

        private IHTTPClient testClient = new TestHTTPClient(); 

        [Fact]
        public void Check_Duns_Info_Method()
        {
            // Assemble
            Sam testSam = new Sam(_key, testClient);
            var expected = typeof(JObject);

            // Act
            var actual = testSam.GetDunsInfo("9990009999");

            // Assert
             Assert.IsType(expected, actual);
        }

        [Fact]
        public void Check_Sam_Status_Method()
        {
            // Assemble
            Sam testSam = new Sam(_key, testClient);
            var expected = typeof(JObject);

            // Act
            var actual = testSam.GetSamStatus("9990009999");

            // Assert
             Assert.IsType(expected, actual);
        }

        [Fact]
        public void Check_Duns_In_Sam_Method()
        {
            // Assemble
            Sam testSam = new Sam(_key, testClient);
            var expected = typeof(JObject);

            // Act
            var actual = testSam.CheckDunsInSam("9990009999");

            // Assert
             Assert.IsType(expected, actual);
        }

        [Fact]
        public void Verify_Not_Excluded_Method()
        {
            // Assemble
            Sam testSam = new Sam(_key, testClient);
            var expected = typeof(JObject);

            // Act
            var actual = testSam.CheckForExclusions("9990009999");

            // Assert
             Assert.IsType(expected, actual);
        }

        [Fact]
        public void Check_Valid_Http_clinet()
        {
            // Assemble
            HTTPClient client = new HTTPClient();

            // Act
            var type = client.GetType();
            MethodInfo methodInfo = type.GetMethod("MakeAPICall");

            // Assert
            Assert.NotNull(methodInfo);
        }

        [Fact]
        public void Check_Sam_Api_Base_Url()
        {
            // Assemble
            var url = Endpoints.SamApiBaseUrl;

            // Assert
            Assert.NotEmpty(url);

        }

        [Fact]
        public void Check_Sam_Status_Url()
        {
            // Assemble
            var url = Endpoints.SamStatusUrl;

            // Assert
            Assert.NotEmpty(url);

        }

        [Fact]
        public void Check_API_Version_Number()
        {
            // Assemble
            var version = Endpoints.SamApiVersion;

            // Assert
            Assert.NotEmpty(version);

        }

        [Fact]
        public void Check_Duns_Info_Path_Template()
        {
            // Assemble
            var template = Endpoints.DunsInfoPathTemplate;

            // Assert
            Assert.NotEmpty(template);

        }

        [Fact]
        public void Check_Status_Path_Template()
        {
            // Assemble
            var template = Endpoints.StatusPathTemplate;

            // Assert
            Assert.NotEmpty(template);

        }
    }
}
