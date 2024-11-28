using System.Text.Json;


//GITHUB:
using HttpClient client = new()
{
    BaseAddress = new Uri("https://api.github.com/")
};

// GitHub API kräver en User-Agent
client.DefaultRequestHeaders.Add("User-Agent", "KonsumeraWebApiLab4APP");



Console.WriteLine("\nRepositories från GitHub:");
var posts = await GetRepositoriesAsync(client);
foreach (var p in posts)
{
    Console.WriteLine($"\n{p}");
}



//ZIPPOPOTAMUS
using HttpClient zippoClient = new()
{
    BaseAddress = new Uri("https://api.zippopotam.us/")
};
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n\nInformation om Montvale, New Jersey:");
var places = await GetPlacesAsync(zippoClient);
foreach (var p in places)
{
    Console.WriteLine($"\n{p}");
}
Console.ResetColor();


// Metod för att hämta(/lista) alla repositories (GitHub)
static async Task<List<GitHubRepo>> GetRepositoriesAsync(HttpClient client)
{
    await using Stream stream =
        await client.GetStreamAsync("orgs/dotnet/repos");
    var result = await JsonSerializer.DeserializeAsync<List<GitHubRepo>>(stream);
    return result ?? new();
}



// Metod för att hämta platser (Zippopotamus)
static async Task<List<ZippopotamusPlace>> GetPlacesAsync(HttpClient client)
{
    await using Stream stream =
        await client.GetStreamAsync("us/nj/montvale");
    var response = await JsonSerializer.DeserializeAsync<ZippopotamusRespons>(stream);
    return response?.Places ?? new();
}
