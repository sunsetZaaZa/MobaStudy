using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;

using MobaGains.Rigging.Configs;
using MobaGains.Rigging.JsonModels.RiotWebApi;
using MobaGains.Rigging.JsonModels.RiotWebApi.Match;
using Newtonsoft.Json;

namespace MobaGains.Rigging;

//Queues: RANKED_SOLO_5X5 , RANKED_FLEX_SR , RANKED_FLEX_TT
//Tier: IRON, BRONZE, SILVER, GOLD, PLATINUM, EMERALD, DIAMOND, MASTER, GRANDMASTER, CHALLENGER
//Division: I, II, III, IV

//Notes: Master, GrandMaster, Challenger do not have divisions

//Regions: NA1 : North America 1
//         LA1 : Latin America 1
//         LA2 : Latin America 2
//         BR1 : Brazil 1
//         EUN1 : Europe North 1
//         EUW1 : Europe West 1
//         JP1 : Japan 1
//         KR : South Korea
//         OC1 : Ilse of Man
//         PH2 : Philippines
//         RU : Russia
//         SG2 : Singapore
//         TH2 : Thailand
//         TR1 : Turkey
//         TW2 : Taiwan
//         VN2 : Vietnam

public interface IMobaHttpClient
{
    Task<AccountDto?> GetAccountInfo(string summonerName, string tagLine, string region);
    Task<ChampionInfoDto?> GetChampionMasteries(string puuid, string championId, string region);
    Task<List<ChampionMasteryDto>?> GetAllChampionMasteries(string puuid, string region);
    Task<ChampionRotationDto?> GetChampionRotation(string region);
    Task<List<LeagueEntryDto>?> GetRankByQueueTierDivision(string queue, string tier, string division, string region);
    Task<LeagueListDto?> GetChallengerRankings(string queue, string region);
    Task<LeagueListDto?> GetGrandmasterRankings(string queue, string region);
    Task<LeagueListDto?> GetMasterRankings(string queue, string region);
    Task<PlatformDataDto?> GetPlatformData(string region);
    Task<MatchesDto?> GetRangeOfMatches(string puuid, long? startTime, long? endTime, int? queue, int? type, int? startIndex, int? length, string region);
    Task<MatchDto?> GetMatch(string matchId, string region);
    Task<SummonerDto?> GetSummonerByAccountId(string accountId, string region);
    Task<SummonerDto?> GetSummonerByName(string summonerName, string region);
    Task<SummonerDto?> GetSummonerByPuuid(string puuid, string region);
    Task<SummonerDto?> GetSummonerBySummonerId(string summonerId, string region);
}

public class MobaHttpClient
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly UserRiotAPIConfig _apiConfig;

    public MobaHttpClient(IHttpClientFactory httpClientFactory, IOptions<UserRiotAPIConfig> apiConfig)
    {
        _httpClientFactory = httpClientFactory;
        _apiConfig = apiConfig.Value;
    }

    public async Task<AccountDto?> GetAccountInfo(string summonerName, string tagLine, string region)
    {
        string uri = "/riot/account/v1/accounts/by-riot-id/" + summonerName + "/" + tagLine;
        HttpClient client = _httpClientFactory.CreateClient();

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, "https://" + region + "." + _apiConfig.apiUri + uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent,  _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" }
            }
        };
        payload.Headers.Add("X-Riot-Token", _apiConfig.riotKey);

        HttpResponseMessage result = await client.SendAsync(payload);

        if (result.IsSuccessStatusCode)
        {
            string contents = await result.Content.ReadAsStringAsync();
            if (contents.Length > 0)
            {
                return JsonConvert.DeserializeObject<AccountDto?>(contents);
            }
        }
        else
        {
            return null;
        }

        return null;
    }

    public async Task<ChampionInfoDto?> GetChampionMasteries(string puuid, string championId, string region)
    {
        string uri = "/lol/champion-mastery/v4/champion-masteries/by-puuid/" + puuid + "/by-champion/" + championId;
        HttpClient client = _httpClientFactory.CreateClient();

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, "https://" + region + "." + _apiConfig.apiUri + uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent,  _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" }
            }
        };
        payload.Headers.Add("X-Riot-Token", _apiConfig.riotKey);

        HttpResponseMessage result = await client.SendAsync(payload);
        if (result.IsSuccessStatusCode)
        {
            string contents = await result.Content.ReadAsStringAsync();
            if (contents.Length > 0)
            {
                return JsonConvert.DeserializeObject<ChampionInfoDto?>(contents);
            }
        }
        else
        {
            return null;
        }

        return null;
    }

    public async Task<List<ChampionMasteryDto>?> GetAllChampionMasteries(string puuid, string region)
    {
        string uri = "/lol/champion-mastery/v4/champion-masteries/by-puuid/" + puuid;
        HttpClient client = _httpClientFactory.CreateClient();

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, "https://" + region + "." + _apiConfig.apiUri + uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent,  _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" }
            }
        };
        payload.Headers.Add("X-Riot-Token", _apiConfig.riotKey);

        HttpResponseMessage result = await client.SendAsync(payload);
        if (result.IsSuccessStatusCode)
        {
            string contents = await result.Content.ReadAsStringAsync();
            if (contents.Length > 0)
            {
                return JsonConvert.DeserializeObject<List<ChampionMasteryDto>?>(contents);
            }
        }
        else
        {
            return null;
        }

        return null;
    }

    public async Task<ChampionRotationDto?> GetChampionRotation(string region)
    {
        string uri = "/lol/platform/v3/champion-rotations";
        HttpClient client = _httpClientFactory.CreateClient();

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, "https://" + region + "." + _apiConfig.apiUri + uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent,  _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" }
            }
        };
        payload.Headers.Add("X-Riot-Token", _apiConfig.riotKey);

        HttpResponseMessage result = await client.SendAsync(payload);
        if (result.IsSuccessStatusCode)
        {
            string contents = await result.Content.ReadAsStringAsync();
            if (contents.Length > 0)
            {
                return JsonConvert.DeserializeObject<ChampionRotationDto?>(contents);
            }
        }
        else
        {
            return null;
        }

        return null;
    }

    public async Task<List<LeagueEntryDto>?> GetRankByQueueTierDivision(string queue, string tier, string division, string region)
    {
        string uri = "/lol/league/v4/entries/" + queue + "/" + tier + "/" + division ;
        HttpClient client = _httpClientFactory.CreateClient();

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, "https://" + region + "." + _apiConfig.apiUri + uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent,  _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" }
            }
        };
        payload.Headers.Add("X-Riot-Token", _apiConfig.riotKey);

        HttpResponseMessage result = await client.SendAsync(payload);
        if (result.IsSuccessStatusCode)
        {
            string contents = await result.Content.ReadAsStringAsync();
            if (contents.Length > 0)
            {
                return JsonConvert.DeserializeObject<List<LeagueEntryDto>?>(contents);
            }
        }
        else
        {
            return null;
        }

        return null;
    }

    public async Task<LeagueListDto?> GetChallengerRankings(string queue, string region)
    {
        string uri = "/lol/league/v4/challengerleagues/by-queue/" + queue;
        HttpClient client = _httpClientFactory.CreateClient();

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, "https://" + region + "." + _apiConfig.apiUri + uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent,  _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" }
            }
        };
        payload.Headers.Add("X-Riot-Token", _apiConfig.riotKey);

        HttpResponseMessage result = await client.SendAsync(payload);
        if (result.IsSuccessStatusCode)
        {
            string contents = await result.Content.ReadAsStringAsync();
            if (contents.Length > 0)
            {
                return JsonConvert.DeserializeObject<LeagueListDto?>(contents);
            }
        }
        else
        {
            return null;
        }

        return null;
    }

    public async Task<LeagueListDto?> GetGrandmasterRankings(string queue, string region)
    {
        string uri = "/lol/league/v4/grandmasterleagues/by-queue" + queue ;
        HttpClient client = _httpClientFactory.CreateClient();

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, "https://" + region + "." + _apiConfig.apiUri + uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent,  _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" }
            }
        };
        payload.Headers.Add("X-Riot-Token", _apiConfig.riotKey);

        HttpResponseMessage result = await client.SendAsync(payload);
        if (result.IsSuccessStatusCode)
        {
            string contents = await result.Content.ReadAsStringAsync();
            if (contents.Length > 0)
            {
                return JsonConvert.DeserializeObject<LeagueListDto?>(contents);
            }
        }
        else
        {
            return null;
        }

        return null;
    }

    public async Task<LeagueListDto?> GetMasterRankings(string queue, string region)
    {
        string uri = "/lol/league/v4/masterleagues/by-queue/" + queue;
        HttpClient client = _httpClientFactory.CreateClient();

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, "https://" + region + "." + _apiConfig.apiUri + uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent,  _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" }
            }
        };
        payload.Headers.Add("X-Riot-Token", _apiConfig.riotKey);

        HttpResponseMessage result = await client.SendAsync(payload);
        if (result.IsSuccessStatusCode)
        {
            string contents = await result.Content.ReadAsStringAsync();
            if (contents.Length > 0)
            {
                return JsonConvert.DeserializeObject<LeagueListDto?>(contents);
            }
        }
        else
        {
            return null;
        }

        return null;
    }

    public async Task<PlatformDataDto?> GetPlatformData(string region)
    {
        string uri = "/lol/league/v4/platform-data";
        HttpClient client = _httpClientFactory.CreateClient();

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, "https://" + region + "." + _apiConfig.apiUri + uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent,  _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" }
            }
        };
        payload.Headers.Add("X-Riot-Token", _apiConfig.riotKey);

        HttpResponseMessage result = await client.SendAsync(payload);
        if (result.IsSuccessStatusCode)
        {
            string contents = await result.Content.ReadAsStringAsync();
            if (contents.Length > 0)
            {
                return JsonConvert.DeserializeObject<PlatformDataDto?>(contents);
            }
        }
        else
        {
            return null;
        }

        return null;
    }

    public async Task<MatchesDto?> GetRangeOfMatches(string puuid, long? startTime, long? endTime, int? queue, int? type, int? startIndex, int? length, string region)
    {
        string uri = "/lol/match/v5/matches/by-puuid/" + puuid + "/ids";
        if (startTime != null)
        {
            uri = uri + "&endTime=" + startTime.Value.ToString();
        }

        if (endTime != null)
        {
            uri = uri + "&endTime=" + endTime.Value.ToString();
        }

        if(queue != null)
        {
            uri = uri + "&queue=" + queue.Value.ToString();
        }

        if(type != null)
        {
            uri = uri + "&type=" + type.Value.ToString();
        }

        if(startIndex != null)
        {
            uri = uri + "&start=" + startIndex.Value.ToString();
        }
        else
        {
            uri = uri + "&start=0";
        }

        if(length != null)
        {
            uri = uri + "&count=" + length.Value.ToString();
        }
        else
        {
            uri = uri + "&count=20";
        }

        HttpClient client = _httpClientFactory.CreateClient();

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, "https://" + region + "." + _apiConfig.apiUri + uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent,  _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" }
            }
        };
        payload.Headers.Add("X-Riot-Token", _apiConfig.riotKey);

        HttpResponseMessage result = await client.SendAsync(payload);
        if (result.IsSuccessStatusCode)
        {
            string contents = await result.Content.ReadAsStringAsync();
            if (contents.Length > 0)
            {
                return JsonConvert.DeserializeObject<MatchesDto?>(contents);
            }
        }
        else
        {
            return null;
        }

        return null;
    }

    public async Task<MatchDto?> GetMatch(string matchId, string region)
    {
        string uri = "/lol/league/v5/matches/" + matchId;
        HttpClient client = _httpClientFactory.CreateClient();

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, "https://" + region + "." + _apiConfig.apiUri + uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent,  _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" }
            }
        };
        payload.Headers.Add("X-Riot-Token", _apiConfig.riotKey);

        HttpResponseMessage result = await client.SendAsync(payload);
        if (result.IsSuccessStatusCode)
        {
            string contents = await result.Content.ReadAsStringAsync();
            if (contents.Length > 0)
            {
                return JsonConvert.DeserializeObject<MatchDto?>(contents);
            }
        }
        else
        {
            return null;
        }

        return null;
    }

    public async Task<SummonerDto?> GetSummonerByAccountId(string accountId, string region)
    {
        string uri = "/lol/summoner/v4/summoners/by-account/" + accountId;
        HttpClient client = _httpClientFactory.CreateClient();

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, "https://" + region + "." + _apiConfig.apiUri + uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent,  _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" }
            }
        };
        payload.Headers.Add("X-Riot-Token", _apiConfig.riotKey);

        HttpResponseMessage result = await client.SendAsync(payload);
        if (result.IsSuccessStatusCode)
        {
            string contents = await result.Content.ReadAsStringAsync();
            if (contents.Length > 0)
            {
                return JsonConvert.DeserializeObject<SummonerDto?>(contents);
            }
        }
        else
        {
            return null;
        }

        return null;
    }

    public async Task<SummonerDto?> GetSummonerByName(string summonerName, string region)
    {
        string uri = "/lol/summoner/v4/summoners/by-name/" + summonerName;
        HttpClient client = _httpClientFactory.CreateClient();

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, "https://" + region + "." + _apiConfig.apiUri + uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent,  _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" }
            }
        };
        payload.Headers.Add("X-Riot-Token", _apiConfig.riotKey);

        HttpResponseMessage result = await client.SendAsync(payload);
        if (result.IsSuccessStatusCode)
        {
            string contents = await result.Content.ReadAsStringAsync();
            if (contents.Length > 0)
            {
                return JsonConvert.DeserializeObject<SummonerDto?>(contents);
            }
        }
        else
        {
            return null;
        }

        return null;
    }

    public async Task<SummonerDto?> GetSummonerByPuuid(string puuid, string region)
    {
        string uri = "/lol/summoner/v4/summoners/by-puuid/" + puuid;
        HttpClient client = _httpClientFactory.CreateClient();

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, "https://" + region + "." + _apiConfig.apiUri + uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent,  _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" }
            }
        };
        payload.Headers.Add("X-Riot-Token", _apiConfig.riotKey);

        HttpResponseMessage result = await client.SendAsync(payload);
        if (result.IsSuccessStatusCode)
        {
            string contents = await result.Content.ReadAsStringAsync();
            if (contents.Length > 0)
            {
                return JsonConvert.DeserializeObject<SummonerDto?>(contents);
            }
        }
        else
        {
            return null;
        }

        return null;
    }

    public async Task<SummonerDto?> GetSummonerBySummonerId(string summonerId, string region)
    {
        string uri = "/lol/summoner/v4/summoners/" + summonerId;
        HttpClient client = _httpClientFactory.CreateClient();

        HttpRequestMessage payload = new HttpRequestMessage(HttpMethod.Get, "https://" + region + "." + _apiConfig.apiUri + uri)
        {
            Headers =
            {
                { HeaderNames.UserAgent,  _apiConfig.userAgent },
                { HeaderNames.AcceptLanguage, _apiConfig.acceptLanguage },
                { HeaderNames.AcceptCharset, "application/x-www-form-urlencoded; charset=UTF-8" }
            }
        };
        payload.Headers.Add("X-Riot-Token", _apiConfig.riotKey);

        HttpResponseMessage result = await client.SendAsync(payload);
        if (result.IsSuccessStatusCode)
        {
            string contents = await result.Content.ReadAsStringAsync();
            if (contents.Length > 0)
            {
                return JsonConvert.DeserializeObject<SummonerDto?>(contents);
            }
        }
        else
        {
            return null;
        }

        return null;
    }
}

