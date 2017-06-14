using System;
using Xunit;
using SamDotNet;
using Newtonsoft.Json.Linq;
using SamDotNet.Helpers;

namespace SamDotNet.Tests
{
    public class SamClientTests
    {
        private readonly HTTPClient client = new HTTPClient(Endpoints.SamApiBaseUrl);
        private readonly string key = "DEMO_KEY";

        [Fact]
        public void Valid_Duns_Test()
        {
            // Assemble
            Sam testSam = new Sam(client, key);
            var expected = typeof(JObject);

            // Act
            var actual = testSam.GetDunsInfo("1459697830000");

            // Assert
            Assert.IsType(expected, actual);
            Assert.NotNull(actual.GetValue("sam_data"));
        }

        [Fact]
        public void Invalid_Duns_Test()
        {
            // Assemble
            Sam testSam = new Sam(client, key);
            var expected = typeof(JObject);

            // Act
            var actual = testSam.GetDunsInfo("0000000000000");

            // Assert
            Assert.IsType(expected, actual);
            Assert.NotNull(actual.GetValue("error"));
        }
    }
}
