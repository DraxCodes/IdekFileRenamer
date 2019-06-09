using System;
using System.Collections.Generic;
using System.Text;
using StarWarsApiSharp.Entities;

namespace StarWarsApiSharp
{
    public interface IStarwarsApiClient
    {
        Starship GetStarship(int id);
        string SerializeObject(object obj);
    }
}
