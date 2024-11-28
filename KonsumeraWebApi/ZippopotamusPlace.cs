using System.Text.Json.Serialization;


public class ZippopotamusPlace
{
    [JsonPropertyName("place name")]
    public string PlaceName { get; set; }

    [JsonPropertyName("longitude")]
    public string Longitude { get; set; }

    [JsonPropertyName("latitude")]
    public string Latitude { get; set; }

    [JsonPropertyName("post code")]
    public string PostCode { get; set; }

    public override string ToString()
    {
        return $"Stad: {this.PlaceName} \nLatitud: {this.Latitude} \nLongitud: {this.Longitude} \nPostnummer: {this.PostCode}";
    }
}
