using Microsoft.Net.Http.Headers;
using System.Net.Http.Headers;

using MobaGains.Rigging.LCU.DataTypes;
using MobaGains.Rigging.JsonModels.LCU;
using Microsoft.AspNetCore.JsonPatch.Internal;

namespace MobaGains.Rigging;

public interface ILCUHttpClient
{
    Task<List<RuneSet>?> GetRunesPages(HttpMethod method, Lockfile key);
    Task<bool> SetRunesPages(HttpMethod method, Lockfile key, RuneSet runeSet);
    Task<bool> CheckRunePageInventory(HttpMethod method, Lockfile key);
}

public class LCUHttpClient : ILCUHttpClient
{
    private readonly IHttpClientFactory _httpClientFactory;

    private static string GetRunePagesURI = "lol-perks/v1/pages"; //HTTP GET & POST & lol-perks/v1/pages/{id}
    private static string RunePageInventoryURI = "lol-perks/v1/inventory"; //HTTP GET
    private static string ValidateRunePageURI = "lol-perks/v1/pages/validate"; //HTTP PUT
    private static string SummonerByIdURI = "lol-summoner/v1/summoners"; //HTTP GET
    private static string ChampionSelectURI = "lol-champ-select/v1/session"; //HTTP GET
    private static string MySelectionURI = "lol-champ-select/v1/session/my-selection"; //HTTP PATCH
    private static string ToggleMutedPlayerURI = "lol-champ-select/v1/toggle-player-muted"; //POST

    public LCUHttpClient(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<List<RuneSet>?> GetRunePages(HttpMethod method, Lockfile key)
    {
        HttpClient client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(key.username, key.password);

        HttpRequestMessage payload = new HttpRequestMessage(method, key.protocol + "://" + key.address + ":" + key.port + "/" + GetRunePagesURI)
        {
            Headers =
            {
                { HeaderNames.Accept, "application/json" },
            }
        };

        HttpResponseMessage result = await client.SendAsync(payload);
        List<RuneSet>? runeSets = null;
        if (result.IsSuccessStatusCode) 
        {
            runeSets = await result.Content.ReadFromJsonAsync<List<RuneSet>>();
        }

        return runeSets;
    }

    public async Task<bool> SetRunesPages(HttpMethod method, Lockfile key, RuneSet runeSet)
    {

    }
}
