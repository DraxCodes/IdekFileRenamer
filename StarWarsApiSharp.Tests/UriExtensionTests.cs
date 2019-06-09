using System;
using StarWarsApiSharp.Entities;
using StarWarsApiSharp.Extensions;
using Xunit;

namespace StarWarsApiSharp.Tests
{
    public class UriExtensionTests
    {
        [Theory]
        [InlineData(24)]
        [InlineData(20)]
        [InlineData(30)]
        public void Extension_ShowThrow_ResponseUriIsNull(int id)
        {
            var json = new Uri($"https://swapi.co/api/starships/{id}");
            var ex = Record.Exception(() => json.ToJson<Starship>());
            Assert.NotNull(ex);
        }
    }
}
