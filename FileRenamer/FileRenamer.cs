using System.IO;
using System.Linq;
using StarWarsApiSharp;

namespace FileRenamer
{
    public class FileRenamer
    {
        private readonly IStarwarsApiClient _swApiClient;
        private const string DirectoryPath = "./RandomFile";
        public FileRenamer(IStarwarsApiClient swApiClient)
        {
            _swApiClient = swApiClient;
        }

        public void ChangeFileNameAndContents(int starshipId)
        {
            var ship = _swApiClient.GetStarship(starshipId);
            var shipAsJson = _swApiClient.SerializeObject(ship);
            Directory.CreateDirectory(DirectoryPath);
            var files = Directory.GetFiles(DirectoryPath);
            var jsonFile = files.FirstOrDefault(x => x.EndsWith(".json"));
            if (jsonFile != null) { File.Delete(jsonFile); }
            File.AppendAllText($"{DirectoryPath}/{ship.Name}.json", shipAsJson);
        }
    }
}
