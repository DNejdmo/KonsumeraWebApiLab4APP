using System;
using System.Text.Json.Serialization;



public class ZippopotamusRespons
{
    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("places")]
    public List<ZippopotamusPlace> Places { get; set; }

    public override string ToString()
    {
        var placesInfo = Places != null
            ? string.Join("\n", Places.Select(p => p.ToString()))
            : "No places available";

        return $"Country: {Country}\nPlaces:\n{placesInfo}";
    }
}





