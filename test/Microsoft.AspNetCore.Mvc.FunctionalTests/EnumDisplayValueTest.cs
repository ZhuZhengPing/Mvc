// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.AspNetCore.Mvc.FunctionalTests
{
    public class EnumDisplayValueTest : IClassFixture<MvcTestFixture<HtmlGenerationWebSite.Startup>>
    {
        public EnumDisplayValueTest(MvcTestFixture<HtmlGenerationWebSite.Startup> fixture)
        {
            Client = fixture.Client;
        }

        public HttpClient Client { get; }

        [Fact]
        public async Task Home_Index_EnumValues()
        {
            // Arrange & Act
            var response = await Client.GetStringAsync("http://localhost/Enum/Index");

            // Assert
            Assert.Contains("Vrijdag\r\nMonth: January", response);
        }
    }
}
