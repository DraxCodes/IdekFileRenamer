using System;
using StarWarsApiSharp.Entities;
using StarWarsApiSharp.Extensions;

namespace StarWarsApiSharp
{
    public class StarwarsApiClient : IStarwarsApiClient
    {
        /// <summary>
        /// Gets starship information from swapi.co
        /// </summary>
        /// <param name="id">The Starship Id, 0-43</param>
        /// <returns></returns>
        public Starship GetStarship(int id)
        {
            if (id < 0 || id > 43) { throw new ArgumentOutOfRangeException(nameof(id)); }
            var websiteUri = new Uri($"https://swapi.co/api/starships/{id}/?format=json");
            return websiteUri.ToJson<Starship>();
        }
    }
}
