using Microsoft.Net.Http.Headers;
using System.Net.Http.Headers;
using System.Text;

using Newtonsoft.Json;

using MobaGains.Rigging.LCU.DataTypes;
using MobaGains.Rigging.JsonModels.LCU;



namespace MobaGains.Rigging;

public interface ILCUHttpClient
{
    Task<List<RuneSet>?> GetRunePages(Lockfile key);
    Task<bool> SetRunesPage(Lockfile key, RuneSet runeSet, string id);
    Task<RuneSetMetadata?> CheckRunePageInventory(Lockfile key);
    Task<RuneSet?> GetRunePage(Lockfile key, string id);
    Task<ValidateRunePageResponse?> ValidateRunePage(Lockfile key, ValidateRunePageRequest details);
    Task<SummonerOverview?> GetOverviewOfSummonerById(Lockfile key, string summonerId);
    Task<SummonerOverview?> GetOverviewOfSummonerByPuuid(Lockfile key, string puuid);
    Task<ChampSelectSession?> GetChampSession(Lockfile key);
    Task<bool> GetMySelection(Lockfile key, MySelection selectionDetails);
    Task<bool> MutePlayer(Lockfile key, MutedPlayer mutedPlayers);
    Task<List<MutedPlayer>?> GetMutedPlayers(Lockfile key);
    Task<SummonerOverview?> GetCurrentSummoner(Lockfile key);
}

public class LCUHttpClient : ILCUHttpClient
{
    private readonly IHttpClientFactory _httpClientFactory;

    private static string RunePagesURI = "lol-perks/v1/pages"; //HTTP GET & PUT & lol-perks/v1/pages/{id}
    private static string RunePageInventoryURI = "lol-perks/v1/inventory"; //HTTP GET
    private static string ValidateRunePageURI = "lol-perks/v1/pages/validate"; //HTTP PUT
    private static string SummonerByIdURI = "lol-summoner/v1/summoners"; //HTTP GET
    private static string SummonerByPuuidURI = "lol-summoner/v2/summoners/puuid"; //HTTP GET
    private static string ChampionSelectURI = "lol-champ-select/v1/session"; //HTTP GET
    private static string MySelectionURI = "lol-champ-select/v1/session/my-selection"; //HTTP PATCH
    private static string ToggleMutedPlayerURI = "lol-champ-select/v1/toggle-player-muted"; //POST
    private static string MutedPlayersURI = "lol-champ-select/v1/muted-players"; //GET
    private static string CurrentSummonerURI = "lol-summoner/v1/current-summoner"; //GET

    public LCUHttpClient(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<List<RuneSet>?> GetRunePages(Lockfile key)
    {
        HttpClient client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(key.username, key.password);

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, key.protocol + "://" + key.address + ":" + key.port + "/" + RunePagesURI)
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

    public async Task<bool> SetRunesPage(Lockfile key, RuneSet runeSet, string id)
    { 
        HttpClient client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(key.username, key.password);

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Put, key.protocol + "://" + key.address + ":" + key.port + "/" + RunePagesURI + "/" + id)
        {
            Headers =
            {
                { HeaderNames.Accept, "application/json" },
            }
        };
        payload.Content = new StringContent(JsonConvert.SerializeObject(runeSet), Encoding.UTF8, "application/json");

        HttpResponseMessage result = await client.SendAsync(payload);
        bool outcome = false;
        if (result.IsSuccessStatusCode)
        {
            outcome = true;
        }

        return outcome;
    }

    public async Task<RuneSetMetadata?> CheckRunePageInventory(Lockfile key)
    {
        HttpClient client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(key.username, key.password);

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Put, key.protocol + "://" + key.address + ":" + key.port + "/" + RunePageInventoryURI)
        {
            Headers =
            {
                { HeaderNames.Accept, "application/json" },
            }
        };

        HttpResponseMessage result = await client.SendAsync(payload);
        RuneSetMetadata? metadata = null;
        if (result.IsSuccessStatusCode)
        {
            metadata = await result.Content.ReadFromJsonAsync<RuneSetMetadata>();
        }

        return metadata;
    }
    public async Task<RuneSet?> GetRunePage(Lockfile key, string id)
    {
        HttpClient client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(key.username, key.password);

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, key.protocol + "://" + key.address + ":" + key.port + "/" + RunePagesURI + "/" + id)
        {
            Headers =
            {
                { HeaderNames.Accept, "application/json" },
            }
        };

        HttpResponseMessage result = await client.SendAsync(payload);
        RuneSet? runeSet = null;
        if (result.IsSuccessStatusCode)
        {
            runeSet = await result.Content.ReadFromJsonAsync<RuneSet>();
        }

        return runeSet;
    }

    public async Task<ValidateRunePageResponse?> ValidateRunePage(Lockfile key, ValidateRunePageRequest details)
    {
        HttpClient client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(key.username, key.password);

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Put, key.protocol + "://" + key.address + ":" + key.port + "/" + ValidateRunePageURI)
        {
            Headers =
            {
                { HeaderNames.Accept, "application/json" },
            }
        };
        payload.Content = new StringContent(JsonConvert.SerializeObject(details), Encoding.UTF8, "application/json");

        HttpResponseMessage result = await client.SendAsync(payload);
        ValidateRunePageResponse? validation = null;
        if (result.IsSuccessStatusCode)
        {
            validation = await result.Content.ReadFromJsonAsync<ValidateRunePageResponse>();
        }

        return validation;
    }

    public async Task<SummonerOverview?> GetOverviewOfSummonerById(Lockfile key, string summonerId)
    {
        HttpClient client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(key.username, key.password);

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, key.protocol + "://" + key.address + ":" + key.port + "/" + SummonerByIdURI + "/" + "%5B" + summonerId + "%5D")
        {
            Headers =
            {
                { HeaderNames.Accept, "application/json" },
            }
        };

        HttpResponseMessage result = await client.SendAsync(payload);
        SummonerOverview? summonerInfo = null;
        if (result.IsSuccessStatusCode)
        {
            summonerInfo = await result.Content.ReadFromJsonAsync<SummonerOverview>();
        }

        return summonerInfo;
    }

    public async Task<SummonerOverview?> GetOverviewOfSummonerByPuuid(Lockfile key, string puuid)
    {
        HttpClient client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(key.username, key.password);

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, key.protocol + "://" + key.address + ":" + key.port + "/" + SummonerByPuuidURI + "/" + puuid)
        {
            Headers =
            {
                { HeaderNames.Accept, "application/json" },
            }
        };

        HttpResponseMessage result = await client.SendAsync(payload);
        SummonerOverview? summonerInfo = null;
        if (result.IsSuccessStatusCode)
        {
            summonerInfo = await result.Content.ReadFromJsonAsync<SummonerOverview>();
        }

        return summonerInfo;
    }

    public async Task<ChampSelectSession?> GetChampSession(Lockfile key)
    {
        HttpClient client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(key.username, key.password);

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, key.protocol + "://" + key.address + ":" + key.port + "/" + ChampionSelectURI)
        {
            Headers =
            {
                { HeaderNames.Accept, "application/json" },
            }
        };

        HttpResponseMessage result = await client.SendAsync(payload);
        ChampSelectSession? session = null;
        if (result.IsSuccessStatusCode)
        {
            session = await result.Content.ReadFromJsonAsync<ChampSelectSession>();
        }

        return session;
    }

    public async Task<bool> GetMySelection(Lockfile key, MySelection selectionDetails)
    {
        HttpClient client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(key.username, key.password);

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, key.protocol + "://" + key.address + ":" + key.port + "/" + MySelectionURI)
        {
            Headers =
            {
                { HeaderNames.Accept, "application/json" },
            }
        };
        payload.Content = new StringContent(JsonConvert.SerializeObject(selectionDetails), Encoding.UTF8, "application/json");

        HttpResponseMessage result = await client.SendAsync(payload);
        bool outcome = false;
        if (result.IsSuccessStatusCode)
        {
            outcome = true;
        }

        return outcome;
    }

    public async Task<bool> MutePlayer(Lockfile key, MutedPlayer mutePlayer)
    {
        HttpClient client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(key.username, key.password);

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Post, key.protocol + "://" + key.address + ":" + key.port + "/" + ToggleMutedPlayerURI)
        {
            Headers =
            {
                { HeaderNames.Accept, "application/json" },
            }
        };
        payload.Content = new StringContent(JsonConvert.SerializeObject(mutePlayer), Encoding.UTF8, "application/json");

        HttpResponseMessage result = await client.SendAsync(payload);
        bool outcome = false;
        if (result.IsSuccessStatusCode)
        {
            outcome = true;
        }

        return outcome;
    }

    public async Task<List<MutedPlayer>?> GetMutedPlayers(Lockfile key)
    {
        HttpClient client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(key.username, key.password);

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, key.protocol + "://" + key.address + ":" + key.port + "/" + MutedPlayersURI)
        {
            Headers =
            {
                { HeaderNames.Accept, "application/json" },
            }
        };

        HttpResponseMessage result = await client.SendAsync(payload);
        List<MutedPlayer>? mutedPlayers = null;
        if (result.IsSuccessStatusCode)
        {
            mutedPlayers = await result.Content.ReadFromJsonAsync<List<MutedPlayer>>();
        }

        return mutedPlayers;
    }

    public async Task<SummonerOverview?> GetCurrentSummoner(Lockfile key)
    {
        HttpClient client = _httpClientFactory.CreateClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(key.username, key.password);

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, key.protocol + "://" + key.address + ":" + key.port + "/" + CurrentSummonerURI)
        {
            Headers =
            {
                { HeaderNames.Accept, "application/json" },
            }
        };

        HttpResponseMessage result = await client.SendAsync(payload);
        SummonerOverview? summoner = null;
        if (result.IsSuccessStatusCode)
        {
            summoner = await result.Content.ReadFromJsonAsync<SummonerOverview>();
        }

        return summoner;
    }
}
