using System;
using Newtonsoft.Json;

namespace StarWarsApiSharp.Entities
{
    public class Starship
    {
        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("model")] public string Model { get; set; }

        [JsonProperty("manufacturer")] public string Manufacturer { get; set; }

        [JsonProperty("cost_in_credits")] public string CostInCredits { get; set; }

        [JsonProperty("length")] public string Length { get; set; }

        [JsonProperty("max_atmosphering_speed")] public string MaxAtmosphericSpeed { get; set; }

        [JsonProperty("crew")] public string Crew { get; set; }

        [JsonProperty("passengers")] public string Passengers { get; set; }

        [JsonProperty("cargo_capacity")] public string CargoCapacity { get; set; }

        [JsonProperty("consumables")] public string Consumables { get; set; }

        [JsonProperty("hyperdrive_rating")] public string HyperdriveRating { get; set; }

        [JsonProperty("MGLT")] public string Mglt { get; set; }

        [JsonProperty("starship_class")] public string StarshipClass { get; set; }

        [JsonProperty("pilots")] public object[] Pilots { get; set; }

        [JsonProperty("films")] public string[] Films { get; set; }

        [JsonProperty("created")] public DateTime Created { get; set; }

        [JsonProperty("edited")] public DateTime Edited { get; set; }

        [JsonProperty("url")] public string Url { get; set; }
    }
}
