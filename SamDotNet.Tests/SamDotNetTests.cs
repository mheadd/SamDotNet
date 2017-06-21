using Xunit;
using SamDotNet.Helpers;
using System.Reflection;

namespace SamDotNet.Tests
{
    public class SamClientTests
    {
        private readonly HTTPClient client = new HTTPClient(Endpoints.SamApiBaseUrl);
        private readonly string key = "DEMO_KEY";

        [Fact]
        public void Check_Duns_Info_Method()
        {
            // Assemble
            Sam testSam = new Sam(key);

            // Act
            var type = testSam.GetType();
            MethodInfo methodInfo = type.GetMethod("GetDunsInfo");

            // Assert
            Assert.NotNull(methodInfo);
        }

        [Fact]
        public void Check_Sam_Status_Method()
        {
            // Assemble
            Sam testSam = new Sam(key);

            // Act
            var type = testSam.GetType();
            MethodInfo methodInfo = type.GetMethod("GetSamStatus");

            // Assert
            Assert.NotNull(methodInfo);
        }

        [Fact]
        public void Check_Duns_In_Sam_Method()
        {
            // Assemble
            Sam testSam = new Sam(key);

            // Act
            var type = testSam.GetType();
            MethodInfo methodInfo = type.GetMethod("CheckDunsInSam");

            // Assert
            Assert.NotNull(methodInfo);
        }

        [Fact]
        public void Verify_Not_Excluded_Method()
        {
            // Assemble
            Sam testSam = new Sam(key);

            // Act
            var type = testSam.GetType();
            MethodInfo methodInfo = type.GetMethod("CheckForExclusions");

            // Assert
            Assert.NotNull(methodInfo);
        }

        [Fact]
        public void Check_Valid_Http_clinet()
        {
            // Assemble
            HTTPClient client = new HTTPClient(Endpoints.SamApiBaseUrl);

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
