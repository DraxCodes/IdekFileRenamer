using System;
using System.Reflection;
using StarWarsApiSharp.Entities;
using Xunit;

namespace StarWarsApiSharp.Tests
{
    public class ClientTests
    {
        [Theory]
        [InlineData(10)]
        [InlineData(21)]
        [InlineData(22)]
        [InlineData(43)]
        public void Client_GetStarship_ShouldReturnStarShipJson_IfIdBetween0_43(int id)
        {
            var client = new StarwarsApiClient();
            var starshipInfo = client.GetStarship(id);
            Assert.IsType<Starship>(starshipInfo);
        }

        [Theory]
        [InlineData(-12)]
        [InlineData(44)]
        [InlineData(50)]
        [InlineData(1000)]
        [InlineData(10000)]
        public void Client_GetStarship_ShouldNullRef_IfNotBetween0_43(int id)
        {
            var client = new StarwarsApiClient();
            var ex = Record.Exception(() => client.GetStarship(id));
            Assert.NotNull(ex);
        }
    }
}
