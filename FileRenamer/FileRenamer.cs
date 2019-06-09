using System.IO;
using StarWarsApiSharp;

namespace FileRenamer
{
    public class FileRenamer
    {
        private readonly IStarwarsApiClient _swApiClient;
        public FileRenamer(IStarwarsApiClient swApiClient)
        {
            _swApiClient = swApiClient;
        }

        public void ChangeFileNameAndContents(int starshipId)
        {
            var ship = _swApiClient.GetStarship(starshipId);
            var shipAsJson = _swApiClient.SerializeObject(ship);
            File.AppendAllText($"{ship.Name}.json", shipAsJson);
        }
    }
}
